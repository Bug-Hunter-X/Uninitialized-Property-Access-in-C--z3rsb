# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: attempting to access a property or field before it has been assigned a value.  This can result in unpredictable behavior, often leading to exceptions (like `NullReferenceException` if the property is a reference type) or unexpected default values (0 for numeric types, false for booleans, null for reference types).  The example shows how to reproduce the problem and how to fix it by ensuring proper initialization.

**Key Concepts:**

* **Initialization:**  Assigning an initial value to variables, properties, or fields before they are used.
* **Default Values:** Understanding the default values of different data types in C#.
* **NullReferenceException:** Knowing how to avoid this common exception by checking for null values before dereferencing objects.

**How to Reproduce:**

Run the `bug.cs` program. You might not see an immediate crash if the property is a value type; however, the result will be unexpected. If the property were a reference type and not initialized, you would get a `NullReferenceException`.

**Solution:**

The solution (`bugSolution.cs`) demonstrates the correct approach by initializing the `MyProperty` before accessing it. This prevents unexpected results and exceptions.