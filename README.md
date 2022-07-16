# Pierre's Bakery Order App

#### By _**Zhibin Liang**_  

#### _A consolo App for ordering bread and/or pastries at Pierre's Bakery_  

---
## Technologies Used

* _C#_
* _.NET_

---
## Description

A consolo App for ordering bread and pastries at Pierre's Bakery. A customer can enter a amount of bread and/or pastries and receive the total of the order(s).

---
## Setup/Installation Requirements

<details>
<summary><strong>To Setup</strong></summary>
<li>Install <em>Microsoft .NET SDK<em></li>
<li>Clone the repo

```sh
$ git clone https://github.com/zbl14/PierreBakery.Solution.git
```
</li>
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>PierreBakery.Solution
   ├── <strong>PierreBakery</strong>
   └── PierreBakery.Tests</pre>

```sh
$ dotnet run
```
</details>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to  
    <pre>PierreBakery.Solution
    ├── PierreBakery
    └── <strong>PierreBakery.Tests</strong></pre>

```sh
$ dotnet restore
```
```sh
$ dotnet test
```

</details>
<br/>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* A non-positive number input to the question of order amount will cause a unhandled exception and quit the application.

## License
MIT

## Contact Information
Zhibin Liang <ifthereisoneday@gmail.com>

Copyright &copy; 2022 Zhibin Liang