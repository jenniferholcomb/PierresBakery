# Pierres Bakery

#### Application that allows a user to buy bread or pastry from Pierres Bakery.

#### By Jennifer Holcomb

## Technologies Used

* C#
* .NET 6
* Node
* MSTest
* Visual Studio

## Description
This application gives a command line prompt asking user if they'd like to purchase bread at $5/loaf, or pastry at $2/pastry. User can specify how many loaves and how many pastries they wish to purchase. Pierre has deals for buying multiple loaves, and multiple pastries. Total cost of order is outputted to user.

## Setup/Installation Requirements

* Clone this repository to your desktop.
* In the PierresBakery.Tests directory restore with $ dotnet restore
* To run tests, in PierresBakery.Tests directory, $ dotnet test
* Create .gitignore file to parent directory
* Add all obj and bin folder to .gitignore file
* Push .gitignore file to repo first
* To compile and run program, within PierresBakery directory, $ dotnet run

## Specs

* Create a new instance of class Bread, with empty constructor
* Create a new instance of class Pastry, with empty constructor
* A method that takes users order, determines if user wants bread, pastry, or both
* A method that calculates cost of how many loaves
* A method that calculates cost of how many pastry

* Return total cost of order to user

## Known Bugs

* _Any known issues_
* If any issues are discovered, please email jenniferlholcomb@gmail.com.

## License
MIT License

Copyright (c) 2022 Jennifer Holcomb

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.