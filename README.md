# Rolodex Contacts

A C# console application built for my SDC320 Object-Oriented Programming course. The Week 1 version displays sample business, family, and friend contacts.

## Run the application

Install the .NET 8 SDK, open a terminal in the folder containing `Rolodex.csproj`, and run:

```bash
dotnet run
```

Enter `1` to display the three sample contacts or `0` to exit.

## Demo
<img width="465" height="316" alt="Screenshot 2026-11-12 at 10 39 16 AM" src="https://github.com/user-attachments/assets/b7ffc6d5-dd3e-4a39-8063-7ae589e0f4eb" />


## Object-oriented design

- **Inheritance:** `BusinessContact`, `FamilyContact`, and `FriendContact` inherit from `Contact`. Each adds its own detail: a company, a family relationship, or how the friend was met.
- **Composition:** Each `Contact` creates and owns a `ContactDetails` object that stores its phone number and email address.

## Planned features

- Add, update, and remove contacts.
- Filter contacts by the first letter of their last name.
