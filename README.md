There is a bug in RadzenDataGrid for Blazor that prevents a hierarchy from being dynamically loaded from a collection of records.
You can reproduce this bug by running this project and trying to expand any of the rows:
![RazdenDataGrid Hierarchy Bug](https://github.com/user-attachments/assets/81a75982-b2c2-41db-a089-543f63876142)

The work around is to use class objects instead of record objects.

This has been observed in Radzen 8.3.0 and 8.4.0.
