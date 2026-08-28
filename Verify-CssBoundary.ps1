$cssFiles = Get-ChildItem -Path .\wwwroot\assets\css -Recurse -Filter *.css
$forbidden = @(
    '^\s*body\s*\{',
    '^\s*html\s*\{',
    '^\s*:root\s*\{',
    '^\s*\.btn\s*\{',
    '^\s*\.navbar\s*\{',
    '^\s*\.nav\s*\{',
    '^\s*\.nav-link\s*\{',
    '^\s*\.form-control\s*\{'
)

$violations = 0
foreach ($file in $cssFiles) {
    foreach ($pattern in $forbidden) {
        $matches = Select-String -Path $file.FullName -Pattern $pattern
        if ($matches) {
            Write-Error "Global CSS Leak in $($file.FullName):"
            $matches | ForEach-Object { Write-Output $_.Line }
            $violations++
        }
    }
}

if ($violations -eq 0) {
    Write-Host "CSS Boundary Check: PASS" -ForegroundColor Green
} else {
    Write-Error "CSS Boundary Check: FAIL ($violations violations found)"
}