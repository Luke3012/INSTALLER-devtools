# INSTALLER devtools

INSTALLER devtools is a specialized utility created to manage and update the OTA (Over-The-Air) update system of **INSTALLER**.  
Originally, INSTALLER’s OTA mechanism could only update the software from one specific version to another (e.g., from `3.0.1` to `3.0.2`, `3.0.3`, or `3.1`), requiring carefully prepared update packages.

Over time, INSTALLER devtools became a graphical interface to directly edit and maintain the INSTALLER database, streamlining the process of adding, configuring, and testing installable packages.

## Features

- **OTA Package Preparation:** Create update packages for specific version jumps.
- **Database Editing:** Modify the INSTALLER database with new software entries.
- **Package Customization:** Add images, names, and configuration details for each program.
- **Link Testing:** Verify that download URLs are functional before deployment.
- **Integrity Checks:** Ensure extraction and installation sequences work as expected.
- **GUI Interface:** Simplifies complex update and configuration tasks.

## How It Was Used

The tool was mainly used to prepare and maintain the list of programs available through INSTALLER:
1. Add or edit a package entry with its metadata (name, icon, configuration).
2. Verify the package’s download link and extraction process.
3. Save the updated database for deployment.
4. Generate OTA packages for specific version upgrades.

## Requirements

- Windows operating system.
- .NET Framework (version compatible with the build).
- Access to the INSTALLER database files.

## Status

Still functional for database editing but no longer used for OTA updates in the original form, as INSTALLER’s update system has evolved.

## License

Provided for archival and educational purposes.
