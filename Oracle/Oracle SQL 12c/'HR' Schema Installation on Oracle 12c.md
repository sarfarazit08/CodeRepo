# 'HR' Schema Installation on Oracle 12c

These steps are to freshly install 'HR' schema if this is not already present in SYS db.
To check if it is present or not you can run the follwing statement after connecting to SYS db.

    + select * from all_users;

### STEPS

1. Connect to **SQLPLUS** 
    + Enter user-name: `SYS / as SYSDBA`
    + Enter password: `<your password>`

2. Run the following command
    + SQL > `alter session set "_ORACLE_SCRIPT" = true;`


3. To run the `hr_main.sql` script, use the following command:
    + SQL> `@?/demo/schema/human_resources/hr_main.sql`

4. Enter a secure password for HR, for example, `Admin123`
    + specify password for HR as parameter 1:
    + Enter value for 1: `<password>` (Check Oracle Database Security Guide for the minimum password requirements)

5. Enter an appropriate tablespace, for example, `hr_tablespace` as the default tablespace for HR
    + specify default tablespace for HR as parameter 2:
    + Enter value for 2: `hr_tablespace`

6. Enter temp as the temporary tablespace for HR, for example, `temp_tablespace`
    + specify temporary tablespace for HR as parameter 3:
    + Enter value for 3: `temp_tablespace`

7. Enter the directory path, for example, `c:/log/`, for your log directory
    + specify log path as parameter 5:
    + Enter value for 5: `c:/log/`

And Voila! It will execute the scripts and create 'HR' schema in a minute.
Run `select * from all_users;` to check again.

### References

+ https://docs.oracle.com/database/121/COMSC/installation.htm#COMSC00004
+ https://stackoverflow.com/questions/33330968/error-ora-65096-invalid-common-user-or-role-name-in-oracle