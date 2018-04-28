import sqlite3

def dbconnection():
    # Create connection to the database
    conn = sqlite3.connect("contacts.db")
    cur = conn.cursor()

    # Create a table
    cur.execute("CREATE TABLE IF NOT EXISTS contacts (id INTEGER PRIMARY KEY, \
    name TEXT, contact TEXT, email TEXT, jobrole TEXT)")
    conn.commit()
    conn.close()

def insert(name, contact, email, jobrole):
    # Create connection to the database
    conn = sqlite3.connect("contacts.db")
    cur = conn.cursor()

    # insert a record
    cur.execute("INSERT INTO contacts VALUES(NULL,?,?,?,?)", (name, contact, email, jobrole))
    conn.commit()
    conn.close()

def view():
    # Create connection to the database
    conn = sqlite3.connect("contacts.db")
    cur = conn.cursor()

    # view records
    cur.execute("Select * from contacts")
    rows = cur.fetchall()
    conn.close()

    return rows

def search(name="", contact="", email="", jobrole=""):
    # Create connection to the database
    conn = sqlite3.connect("contacts.db")
    cur = conn.cursor()

    # search records
    cur.execute("Select * from contacts where name=? or contact=? or email=? or jobrole=?",(name, contact, email, jobrole))
    rows = cur.fetchall()
    conn.close()
    return rows

def delete(id):
    # Create connection to the database
    conn = sqlite3.connect("contacts.db")
    cur = conn.cursor()

    # delete records
    cur.execute("Delete from contacts where id=?", (id,))
    conn.commit()
    conn.close()

def update(id, name, contact, email, jobrole):
    # Create connection to the database
    conn = sqlite3.connect("contacts.db")
    cur = conn.cursor()

    # update records
    cur.execute("UPDATE contacts SET name=?, contact=?, email=?, jobrole=? where id=?", (name, contact, email, jobrole, id))
    conn.commit()
    conn.close()


dbconnection()