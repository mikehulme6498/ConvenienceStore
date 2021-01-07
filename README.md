# Convenience Store Tech Interview Question

Built in visual studio 2019 in .Net core

Cloned repository should just build and run in visual studio. 

Unit tests cover all scenarios of the business rules. I used nUnit as my testing framework.

The idea of the structure was to make it easy to create new shop items and new quality rules. The rules are injected into the classes allowing sharing of rules, 
I.e Frozen and fresh items share the same rules only fresh items are doubled.

When you run the program you will see the current inventory and you will be asked how many days you want to skip forward. 
Once you have done that you can continue advancing more days, start again or quit.

Hope you like it!
