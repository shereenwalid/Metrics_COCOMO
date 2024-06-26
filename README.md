# COCOMO

This project implements the Constructive Cost Model (COCOMO) to estimate the cost and schedule associated with software development. \n
COCOMO is an industry-standard model that offers a structured approach to software project planning and resource allocation.

## Table of Contents

- [Features](#features)
- [Requirements](#requirements)
- [How to Run](#how-to-run)
- [Usage](#usage)
- [Screenshots](#screenshots)

## Features

- **Effort Estimation**: Estimate the effort required for software development based on project characteristics.
- **Schedule Estimation**: Predict the schedule for completing the software development project.
- **Major Models Selection**: Choose between **Basic or Intermediate COCOMO models** for effort and schedule estimation.
- **Flexible Mode Selection**: Choose between different development modes such as Organic, Semidetached, and Embedded to tailor the estimation process to your project. \n
    These modes influence the cost driver values used in the Intermediate COCOMO model.
    - **Organic Mode:** Suitable for small projects with a relatively inexperienced team.
    - **Semidetached Mode:** Applicable to projects of moderate size with a mix of experienced and inexperienced team members.
    - **Embedded Mode:** Ideal for large projects with a well-experienced team.

## Requirements

- .NET Framework 4.7.2 or later

## How to Run

1. Clone this repository to your local machine.
2. Open the solution file (Metrics_COCOMO.sln) in Visual Studio.
3. Build the solution.
4. Run the application from Visual Studio or navigate to the output directory and execute the executable file.

## Usage

- Upon running the application, you will be presented with options either Basic or Intermediate model
- Enter required input data such as:
    - KLOC (for both Basic and Intermediate models)
    - Mode (Organic, Semidetached, or Embedded - required for Intermediate model only)
- If mode not selected the app is set to detect it through num of KLOC
- Choose the appropriate attribute you want to calculate: Effort or Development Time (TDEV)

## Screenshots

## Main
<img width="802" alt="main" src="https://github.com/shereenwalid/Metrics_COCOMO/assets/93673791/bf89b6aa-8393-4a80-a9a5-ce54af656bb0">

## Intermediate Input 
<img width="796" alt="IntermediateInput" src="https://github.com/shereenwalid/Metrics_COCOMO/assets/93673791/098a5e45-0b64-4c9a-949a-23d3a56dde82">

## Cost Drivers Input
<img width="772" alt="CostDriverCalc" src="https://github.com/shereenwalid/Metrics_COCOMO/assets/93673791/e852c4ff-1a3e-407e-b0aa-adfffc21404b">

