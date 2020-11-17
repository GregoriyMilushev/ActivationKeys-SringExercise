Programming Fundamentals Final Exam 04.04.2020
Problem 1. Activation Keys

The first line of the input will be your raw activation key. It will consist of letters and numbers only. 
After that, until the "Generate" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the raw activation key.
There are several types of instructions, split by ">>>":
•	Contains>>>{substring} – checks if the raw activation key contains the given substring.
o	If it does prints: "{raw activation key} contains {substring}".
o	If not, prints: "Substring not found!"
•	Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}
o	Changes the substring between the given indices (the end index is exclusive) to upper or lower case. 
o	All given indexes will be valid.
o	Prints the activation key.
•	Slice>>>{startIndex}>>>{endIndex}
o	Deletes the characters between the start and end indices (end index is exclusive).
o	Both indices will be valid.
o	Prints the activation key.
Input
•	The first line of the input will be string and it will consist of letters and numbers only. 
•	After the first line, until the "Generate" command is given, you will be receiving strings.
Output
•	After the "Generate" command is received, print:
o	"Your activation key is: {activation key}"

Examples:
Input	:
abcdefghijklmnopqrstuvwxyz
Slice>>>2>>>6
Flip>>>Upper>>>3>>>14
Flip>>>Lower>>>5>>>7
Contains>>>def
Contains>>>deF
Generate

Output:
abghijklmnopqrstuvwxyz
abgHIJKLMNOPQRstuvwxyz
abgHIjkLMNOPQRstuvwxyz
Substring not found!
Substring not found!
Your activation key is: abgHIjkLMNOPQRstuvwxyz

Comments:!!!
1.	Slice>>2>>6 
abcdefghijklmnopqrstuvwxyz becomes abghijklmnopqrstuvwxyz
2.	Flip>>>Upper>>>3>>>14
abghijklmnopqrstuvwxyz becomes abgHIJKLMNOPQRstuvwxyz
3.	Flip>>>Lower>>>5>>>7
abgHIJKLMNOPQRstuvwxyz becomes abgHIjkLMNOPQRstuvwxyz
4.	Contains>>>def
abgHIjkLMNOPQRstuvwxyz does not contain def
5.	Contains>>>deF
abgHIjkLMNOPQRstuvwxyz does not contain deF
The final activation key is abgHIjkLMNOPQRstuvwxyz

Other Input	:
134softsf5ftuni2020rockz42
Slice>>>3>>>7
Contains>>>-rock
Contains>>>-uni-
Contains>>>-rocks
Flip>>>Upper>>>2>>>8
Flip>>>Lower>>>5>>>11
Generate

Output:
134sf5ftuni2020rockz42
Substring not found!
Substring not found!
Substring not found!
134SF5FTuni2020rockz42
134SF5ftuni2020rockz42
Your activation key is: 134SF5ftuni2020rockz42

