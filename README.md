# wpf-FratagoniaUI

Collection of multipurpose C# WPF sleek controls in development at RedEddieLabs.

## Overview

**wpf-FratagoniaUI** is a modern library of custom WPF controls that empower you to create sleek, responsive user interfaces with ease. One of our key components is the **UniProgressBarControl** – an animated, highly customizable progress bar designed to bring a touch of sophistication to any application.

## Technologies Used

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![XAML](https://img.shields.io/badge/XAML-0C54C2?style=for-the-badge&logo=xaml&logoColor=white)

## Table of Contents

- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)




## Features

- **UniProgressBarControl**
  - Animated progress filling with smooth easing functions.
  - Customizable appearance with dependency properties for colors, corner radius, and dimensions.
  - Easy integration in both local and cross-project scenarios.
- Built for .NET 6.0, .NET 7.0, and .NET 8.0 with WPF.
- Sample application included to demonstrate control usage.

## Getting Started

### Prerequisites

- [.NET 6.0+ SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 (or later) or Visual Studio Code with C# extensions.
- A Windows environment with WPF support.

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/EddieRedLabs/wpf-FratagoniaUI.git
   ```
2. **Open the Solution**
   - Open the `FratagoniaUI.sln` file in Visual Studio or VS Code.
3. **Build the Project**
   - Restore NuGet packages and build the solution.

### Usage

To use the **UniProgressBarControl** in your XAML, add the following namespace:

```xml
xmlns:UniProgressBarControl="clr-namespace:UniProgressBarControl;assembly=UniProgressBarControl"
```

Then, add the control in your XAML file:

```xml
<UniProgressBarControl:UniProgressBar
    x:Name="UniProgressBarSample"
    MinWidth="100"
    MinHeight="40"
    Margin="5"
    Background="White"
    BorderThickness="0.5"
    CornerRadiusForFillIndicator="5"
    CornerRadiusForTrack="5"
    DisplayTextHeight="10"
    FillTimeDuration="0:0:1"
    FontWeight="Bold"
    Foreground="Black"
    HeightForProgressBar="5"
    MaximumValue="100.0"
    ProgressValue="69.0"
    Loaded="UniProgressBarSample_Loaded" />
```

For more details, refer to the sample application in the `FratagoniaUI.OSS` project.

## Project Structure

- **FratagoniaUI/**
  - **UniProgressBarControl/**
    - `UniProgressBar.cs` – Custom progress bar control implementation.
    - `Converters/ProgressToColorConverter.cs` – Converter to dynamically adjust colors based on progress.
    - `Themes/Generic.xaml` – Default styling and control templates.
    - `AssemblyInfo.cs`
- **FratagoniaUI.OSS/**
  - A sample WPF application showcasing the controls.
  - `App.xaml` and `App.xaml.cs` – Application entry point.
  - `Windows/OSSMainWindow.xaml` and `OSSMainWindow.xaml.cs` – Main window demonstrating control usage.
- Additional files:
  - `LICENSE` – Project license.
  - `.gitignore` – Git configuration to exclude unnecessary files.

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Open a pull request for review.

If you have major changes, please open an issue first to discuss the details.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for complete details.

## Contact

For questions or feedback, please contact [Eddie Ruano](mailto:secretary@ruanoestate.com).

---

Created with ❤️ by RedEddieLabs.