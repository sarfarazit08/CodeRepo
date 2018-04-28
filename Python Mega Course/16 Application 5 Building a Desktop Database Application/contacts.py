"""
A program that stores these contact Informations:

+ Name
+ Contact No.
+ E-mail Id
+ Job role.

User can:

+ View all contacts
+ Search a contact
+ Add a contact
+ Update a contact
+ Delete a contact
+ Close the program

"""

from tkinter import *
import dbconnection


# Button Commands
def view_cmd():
    lstBox.delete(0,END)
    for row in dbconnection.view():
        lstBox.insert(END,row)

def search_cmd():
    lstBox.delete(0,END)
    for row in dbconnection.search(txtNameVar.get(),txtContactVar.get(),txtEmailVar.get(),txtJobroleVar.get()):
        lstBox.insert(END,row)

def add_cmd():
    dbconnection.insert(txtNameVar.get(),txtContactVar.get(),txtEmailVar.get(),txtJobroleVar.get())
    lstBox.delete(0,END)
    lstBox.insert(END,(txtNameVar.get(),txtContactVar.get(),txtEmailVar.get(),txtJobroleVar.get()))

def delete_cmd():
    lstBox.delete(0,END)

# GUI Window
window = Tk()

# labels
lblName = Label(window,text="Name")
lblName.grid(row=0, column=0)


lblEmail = Label(window,text="E-mail")
lblEmail.grid(row=0, column=4)


lblContact = Label(window,text="Contact No.")
lblContact.grid(row=1, column=0)


lblJobrole = Label(window,text="Job Role")
lblJobrole.grid(row=1, column=4)


# Text boxes
txtNameVar = StringVar()
txtNameEntry = Entry(window,textvariable=txtNameVar)
txtNameEntry.grid(row=0, column=1, columnspan = 3)

txtEmailVar = StringVar()
txtEmailEntry = Entry(window,textvariable=txtEmailVar)
txtEmailEntry.grid(row=0, column=5, columnspan = 3)

txtContactVar = StringVar()
txtContactEntry = Entry(window,textvariable=txtContactVar)
txtContactEntry.grid(row=1, column=1, columnspan = 3)

txtJobroleVar = StringVar()
txtJobroleEntry = Entry(window,textvariable=txtJobroleVar)
txtJobroleEntry.grid(row=1, column=5, columnspan = 3)

# List Box
lstBox = Listbox(window,height=10, width = 35)
lstBox.grid(row=2,column = 0, rowspan = 10, columnspan = 4)

# Scroll Bar
sclBar = Scrollbar(window)
sclBar.grid(row=2,rowspan = 10, column=4)

# Configure Scroll bar and List Box
lstBox.configure(yscrollcommand=sclBar.set)
sclBar.configure(command=lstBox.yview)

# Action Buttons

"""
+ View all contacts
+ Search a contact
+ Add a contact
+ Update a contact
+ Delete a contact
+ Close the program
"""

btnViewAll = Button(window,text="View all contacts",width = 20, command=view_cmd)
btnViewAll.grid(row=2, column=5)

btnSearchContact = Button(window,text="Search a contact",width = 20, command=search_cmd)
btnSearchContact.grid(row=3, column=5)

btnAddContact = Button(window,text="Add a contact",width = 20, command=add_cmd)
btnAddContact.grid(row=4, column=5)

btnUpdateContact = Button(window,text="Update a contact",width = 20)
btnUpdateContact.grid(row=5, column=5)

btnDeleteContact = Button(window,text="Delete a contact",width = 20)
btnDeleteContact.grid(row=6, column=5)

btnCloseProgram = Button(window,text="Close Program",width = 20)
btnCloseProgram.grid(row=7, column=5)

window.mainloop()