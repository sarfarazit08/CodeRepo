import sqlite3

def create_table(table_name):
    # Create connection to the database
    conn = sqlite3.connect("sqldb.db")
    cur = conn.cursor()

    # Create a table
    cur.execute("CREATE TABLE IF NOT EXISTS " + table_name + "(item TEXT, quantity INTEGER, price REAL)")
    conn.commit()
    conn.close()

def insert(item, quantity, price):
    # Create connection to the database
    conn = sqlite3.connect("sqldb.db")
    cur = conn.cursor()

    # Insert a record
    cur.execute("INSERT INTO store VALUES(?,?,?)", (item,quantity,price))
    conn.commit()
    conn.close()

def view():
    # Create connection to the database
    conn = sqlite3.connect("sqldb.db")
    cur = conn.cursor()

    # View records
    cur.execute("Select * from store")
    rows = cur.fetchall()
    conn.close()

    return rows

def delete(item):
    # Create connection to the database
    conn = sqlite3.connect("sqldb.db")
    cur = conn.cursor()

    # View records
    cur.execute("Delete from store where item = ?", (item,))
    conn.commit()
    conn.close()

def delete_all():
    # Create connection to the database
    conn = sqlite3.connect("sqldb.db")
    cur = conn.cursor()

    # View records
    cur.execute("Delete from store")
    conn.commit()
    conn.close()

def update(quantity, price, item):
    # Create connection to the database
    conn = sqlite3.connect("sqldb.db")
    cur = conn.cursor()

    # View records
    cur.execute("UPDATE store SET quantity = ? , price = ? where item = ?", (quantity, price, item))
    conn.commit()
    conn.close()


# create_table("store")
# insert('Wine Glass', 15, 20.25)
# delete('Tea Cup')
# update(30, 4.75,'Tea Cup')
# delete_all()
print(view())