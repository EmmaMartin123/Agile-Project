# Agile-Project

Naming Rules:

 - FunctionNames
 - ClassNames
 - file_names

Styling Info for ATM:

---- Colours ----
- Background RGB: 203, 216, 235
- Text RGB: 2, 7, 93
- Button background RGB: 163, 179, 201
- Hover RGB: 203, 216, 235

---- Fonts ----

- Font: Segoe UI
- On Hero Buttons: BOLD, 24pt, vertically and horizontally centred, all text should be capitalised
- On Additional Buttons: BOLD, 20pt ''
- For Plain Text: REGULAR, 20pt, vertically and horizontally centred, normal grammar and capitalisation
- For Headings: BOLD, 28pt, horizontally centred, Leading capitals 

---- Display ----

- Form background should be tertiary colour
- Windows in the form should have secondary colour background
- Windows in the form should have no border
- All text should be primary colour
- Buttons should be flat with a primary colour border of size 3
- Windows in forms should be vertically and horizontally centred
- Forms should be full screen

---- Sizing ----


---- Interaction ----

- ?could be cool if on hover buttons set their background colour to primary and their text colour to tertiary. Also should be relatively easy to implement

=======
Data Rules:

 - Transaction ID: integer, 4 digits long
 - ATM ID: integer, 4 digits long
 - PAN: string, 16 characters long, starts with 2, 3, 4 or 5
 - Pin: integer, 4 digits long
 - Transaction outcome: integer, -1 (initially), 0 (success), 1 (failure: insufficient funds), 10 (error)
 - Transaction type: integer, 0 (display balance), 1 (withdraw)
 - Transaction value (i.e. the amount to be withdrawn, or balance to be displayed): integer, should be a multiple of 5
