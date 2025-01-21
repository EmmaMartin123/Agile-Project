# Agile-Project

Naming Rules:

 - functionNames
 - ClassNames
 - file_names

Data Rules:

 - Transaction ID: integer, 4 digits long
 - ATM ID: integer, 4 digits long
 - PAN: string, 16 characters long, starts with 2, 3, 4 or 5
 - Pin: integer, 4 digits long
 - Transaction outcome: integer, -1 (initially), 0 (success), 1 (failure: insufficient funds), 10 (error)
 - Transaction type: integer, 0 (display balance), 1 (withdraw)
 - Transaction value (i.e. the amount to be withdrawn, or balance to be displayed): integer, should be a multiple of 5
