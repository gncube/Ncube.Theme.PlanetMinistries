#!/usr/bin/env bash
set -euo pipefail

# Rename helper for Ncube.Theme.PlanetMinistries -> Ncube.Theme.PlanetMinistries
# Usage:
#   bash rename_theme.sh         # dry-run (shows planned changes)
#   bash rename_theme.sh --apply # perform replacements and renames

OLD="Ncube.Theme.PlanetMinistries"
NEW="Ncube.Theme.PlanetMinistries"
APPLY=false

if [ "${1:-}" = "--apply" ]; then
  APPLY=true
fi

echo "Root: $(pwd)"
echo "Old: $OLD"
echo "New: $NEW"
echo

echo "Gathering files that contain the old identifier (text search)..."
mapfile -t FILES < <(grep -RIl --binary-files=without-match --exclude-dir=.git --exclude-dir=bin --exclude-dir=obj "$OLD" . || true)

if [ ${#FILES[@]} -eq 0 ]; then
  echo "No files found containing '$OLD'."
else
  echo "Files to update (content replacements):"
  for f in "${FILES[@]}"; do
    echo "  $f"
  done
fi

echo
echo "Gathering filesystem paths that contain the old identifier (names)..."
mapfile -t PATHS < <(find . -depth -name "*${OLD}*" 2>/dev/null || true)

if [ ${#PATHS[@]} -eq 0 ]; then
  echo "No files or directories found with '$OLD' in the name."
else
  echo "Paths to rename (files/directories):"
  for p in "${PATHS[@]}"; do
    echo "  $p -> ${p//$OLD/$NEW}"
  done
fi

if [ "$APPLY" = false ]; then
  echo
  echo "DRY RUN complete. To apply these changes, run:" 
  echo "  bash $0 --apply"
  exit 0
fi

echo
echo "Applying text replacements..."
for file in "${FILES[@]}"; do
  echo "Updating: $file"
  if command -v perl >/dev/null 2>&1; then
    # Use perl for robust in-place, multi-line and special-char safe replacement
    perl -0777 -pe "s/\Q$OLD\E/$NEW/g" -i.bak "$file" && rm -f "$file.bak"
  else
    # Fallback to sed (GNU sed expected)
    sed -i.bak "s|$OLD|$NEW|g" "$file" && rm -f "$file.bak"
  fi
done

echo
echo "Applying file and directory renames (deepest-first)..."
# Rename deepest paths first to avoid moving parent directories before children
while IFS= read -r -d '' path; do
  newpath="${path//$OLD/$NEW}"
  echo "Renaming: $path -> $newpath"
  mv "$path" "$newpath"
done < <(find . -depth -name "*${OLD}*" -print0 2>/dev/null)

# Rename solution file if present
if [ -f "Ncube.Theme.PlanetMinistries.sln" ]; then
  echo "Renaming solution file..."
  mv "Ncube.Theme.PlanetMinistries.sln" "Ncube.Theme.PlanetMinistries.sln"
fi

echo
echo "Replacement and renaming complete."
echo "Please review changes (git status/diff) and run 'dotnet restore' and open the solution to verify everything builds."
