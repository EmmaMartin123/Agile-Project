# Agile-Project

## Naming Rules

 - functionNames
 - ClassNames
 - file_names

## Data Rules

 - Transaction ID: integer, 4 digits long
 - ATM ID: integer, 4 digits long
 - PAN: string, 16 characters long, starts with 2, 3, 4 or 5
 - Pin: integer, 4 digits long
 - Transaction outcome: integer, -1 (initially), 0 (success), 1 (failure: insufficient funds), 10 (error)
 - Transaction type: integer, 0 (display balance), 1 (withdraw)
 - Transaction value (i.e. the amount to be withdrawn, or balance to be displayed): integer, should be a multiple of 5

## Code Review

Use these guidelines to review code after testing but before merging.

Before beginning make sure you understand the context. Read the user story and issue the code came from. Read the previous commits around it.

Check for:
- Logic errors
- Innefficiencies
- Repitition
- Readability
- Commenting
- Conforming to rules e.g naming. See above.

If the work does not meet these standards then provide constructive feedback.

What is constructive feedback?
- Don't just say what requires change, say why and even how.
- Reference specific lines and methods/functions.
- Highlight positives as well as negatives.
- Be clear and concise. Avoid unneccessary complexity and jargon. Don't yap.

Take your time.

From Google's coding standards:
A key point here is that there is no such thing as “perfect” code—there is only better code. Reviewers should not require the author to polish every tiny piece before granting approval. Rather, the reviewer should balance out the need to make forward progress compared to the importance of the changes they are suggesting.
