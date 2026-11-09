# 🚀 Week-01: C# Programming Fundamentals & Algorithms

> **Flex Ops Full Stack Internship** — Training Repository for Week 01

This folder contains the comprehensive documentation and source code for the projects and programming problems executed during **Week 01** of the training program. This week focuses on understanding core C# logic, input management, data validation, error handling, and working with methods, loops, and arrays.

## 📂 Folder Structure

```
FullStack_Internship/Week-01/
├── Week01.Calculator/
│   ├── Program.cs
│   ├── Week01.Calculator.csproj
│   └── Week01.Calculator.slnx
├── Week01.ProgrammingProblims10/
│   ├── Program.cs
│   ├── Week01.ProgrammingProblims10.csproj
│   └── Week01.ProgrammingProblims10.slnx
├── Week01.StudentGrades/
│   ├── Program.cs
│   ├── Week01.StudentGrades.csproj
│   └── Week01.StudentGrades.slnx
└── README.md
```

## 🛠️ Detailed Explanation of All Projects and Codebase

### 1️⃣ Calculator Project (`Week01.Calculator`)

The code includes the implementation of an interactive calculator with input protection using `try-catch` and `while (true)`.

#### **Workflow:**

1. **Reading Inputs:**
   * Reading the first number (`FN1`) and converting it using `Convert.ToInt32()`.
   * Reading the arithmetic operation (`OP`).
   * Reading the second number (`SN2`) and converting it in the same manner.

2. **Supported Operations:**
   * **Addition (`+`):** `FN1 + SN2`
   * **Subtraction (`-`):** `FN1 - SN2`
   * **Multiplication (`*`):** `FN1 * SN2`
   * **Division (`/`):** `FN1 / SN2`
   * **Modulo (`%`):** `FN1 % SN2`

3. **Validation & Exceptions:**
   * In case an unsupported operation symbol is entered, `Invalid Operation! Please try again.` is printed, and re-entry is triggered via `continue`.
   * In case non-numeric values are entered, the exception is caught by printing `e.Message` and repeating the loop.
   * The loop terminates with `break` immediately upon successful completion of the operation.

---

### 2️⃣ Student Grade Calculation & Evaluation Project (`Week01.StudentGrades`)

This program prompts for the student's name and their grades in three subjects, then calculates the average score and final grade.

#### **Workflow:**

1. **Data Input:**
   * Reading the full name of the student (`string name`).
   * Reading 3 grades: `M1`, `M2`, `M3`.

2. **Grade Validation:**
   * The condition is verified:
     `M1 >= 0 && M1 <= 100 && M2 >= 0 && M2 <= 100 && M3 >= 0 && M3 <= 100`
   * If any of the marks fall outside this range, the program prints:
     `Invalid Enter . Plase Re-Enter The Marks ( 0 - 100) .`
     and retries using `continue`.

3. **Average Calculation (`Avg`):**
   * `Sum += M1 + M2 + M3;`
   * `Avg = Sum / NumOfMarks;` (where `NumOfMarks = 3`).

4. **Determining the Final Grade:**
   * **`Avg >= 90`** 👈 `(A)`
   * **`Avg >= 80`** 👈 `(B)`
   * **`Avg >= 70`** 👈 `(C)`
   * **`Avg >= 50`** 👈 `(D)`
   * **Below 50** 👈 `(F)`

5. **Error Handling:**
   * Protecting the code via `try-catch (Exception ex)` with `continue` when invalid data is entered.

---

### 3️⃣ 10 Programming Problems Project (`Week01.ProgrammingProblims10`)

The class contains 10 independent programming methods aiming to solidify core algorithmic concepts:

#### **1. `Even_Or_Odd()` — Check if Number is Even or Odd**
* Prompts for entering a number `num` as a `double`.
* Checks the remainder of division by 2 (`num % 2 == 0`).
* Prints whether the number is **Even** or **Odd** with `try-catch` protection.

#### **2. `MaxNumber()` — Find Maximum Number**
* Prompts for sequential numbers using a `while (true)` loop.
* Iteration stops when `-1` is entered.
* Replaces values and updates the `max` value using `Math.Max(d, num)`.
* Returns the highest entered number (`double max`).

#### **3. `SumNum()` — Sum of Formatted Numbers**
* Prompts for numbers and adds them to the `sum` variable.
* Stops when `-1` is entered.
* Returns the total sum of all entered numbers.

#### **4. `Multiplication_Table()` — Multiplication Table**
* Prompts for the multiplication table number `num`.
* Uses a `for (int i = 1; i <= 12; i++)` loop to print the table in a structured format.

#### **5. `Sum_Array()` — Sum Array Elements**
* Prompts for setting the array size (`size`).
* Instantiates an array of type `double[] arr = new double[size];`.
* Sums all entered numbers, stores them in the array, and returns the grand total `sum`.

#### **6. `Reverse_The_Text()` — Reverse String**
* Reads the string and converts it to lower case `text.ToLower()`.
* Iterates using a reverse `for` loop from `text.Length - 1` down to `0` to build the reversed string.
* Returns the reversed string.

#### **7. `Palindrome()` — Check Palindrome String**
* Accepts a string and reverses it using the same mechanism as `Reverse_The_Text()`.
* Compares the reversed text with the original `if (reverse == text)`.
* Prints `Is Palindrome` or `Is Not Palindrome`.

#### **8. `Count_Vowels()` — Count Vowels**
* Reads a word or sentence and converts it using `ToLower()`.
* Evaluates each character in a loop, incrementing `count++` if it matches (`a, e, i, o, u`).
* Returns the total count of vowel letters.

#### **9. `Prime()` — Check Prime Number**
* Prompts for a number input and evaluates whether it is a prime number.
* Includes input protection via `try-catch`.

#### **10. `Factorial()` — Calculate Factorial**
* Prompts for a number `num` and assigns its value to variable `f`.
* Iterates using a decrementing loop (`i = num - 1; i > 0; i--`) to compute `f *= i`.
* Returns the final factorial result of the number.

---

## 💻 How to Run Using Visual Studio

To run any of the three projects easily:

1. **Open the appropriate solution file (`.slnx`):**
   * Navigate to the target project folder (e.g., `Week01.Calculator`).
   * Double-click on the designated solution file for the project:
     * 🔹 `Week01.Calculator.slnx`
     * 🔹 `Week01.ProgrammingProblims10.slnx`
     * 🔹 `Week01.StudentGrades.slnx`
   * The project will open directly in **Visual Studio**.

2. **Direct Execution:**
   * Press **F5** to run in Debugging mode.
   * Or press **Ctrl + F5** for fast direct execution from the console.

---

## 🧪 Test Sessions & Execution Examples

### 🔹 Student Grades Project (`Week01.StudentGrades`):

```text
Enter Your FullName : 
Abdalrhman
Enter Mark1 : 
95
Enter Mark2 : 
90
Enter Mark3 : 
85
The Student : Abdalrhman , The Grade and Avarage is :   (A) 90
```

### 🔹 Calculator Project (`Week01.Calculator`):

```text
Enter First Number = 10
Enter Operation ( + , - , * , / , %) : *
Enter Second Number = 5
Multiplication :- First Number * Scaund Number = 50
```

### 🔹 Count Vowels Method (`Count_Vowels`):

```text
Enter The Word Or The Statment : 
hello world
The Count Vowels = 3
```