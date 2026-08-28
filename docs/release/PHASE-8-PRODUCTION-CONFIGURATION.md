# Phase 8 — Production Configuration Guide

## Environment Variables & AppSettings
Ensure the following production settings are supplied via external environment configuration:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "Oqtane": "Information",
      "Ncube.Theme.PlanetMinistries": "Information"
    }
  },
  "ThemeSettings": {
    "BrandFooterCopy": "&copy; 2026 Planet Ministries. All rights reserved.",
    "EnableSearch": true,
    "EnableLogin": true
  }
}