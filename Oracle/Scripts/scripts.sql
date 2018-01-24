--ALTER USER hr ACCOUNT UNLOCK IDENTIFIED BY <Password>;

SELECT *
FROM employees
WHERE hire_date BETWEEN '01-JAN-1999' AND '01-MAR-2016';

SELECT count(*) FROM employees WHERE last_name 
BETWEEN 'B____' and 'C____';
SELECT department_id,
  department_name,
  manager_id,
  location_id
FROM departments
WHERE location_id = 1700
ORDER BY manager_id DESC;
SELECT emp.employee_id ,
  dept.department_name
FROM employees emp ,
  departments dept
WHERE emp.department_id = dept.department_id
ORDER BY emp.employee_id;
/
SELECT emp.employee_id ,
  dept.department_name
FROM employees emp
INNER JOIN departments dept USING (department_id )
ORDER BY emp.employee_id;
/
SELECT emp.employee_id ,
  dept.department_name
FROM employees emp
INNER JOIN departments dept
ON ( emp.department_id = dept.department_id)
ORDER BY emp.employee_id;
/
SELECT emp1.last_name employee,
  emp2.last_name manager
FROM employees emp1
INNER JOIN employees emp2
ON ( emp1.manager_id = emp2.employee_id)
ORDER BY emp1.last_name;
/
SELECT e.employee_id,
  e.first_name
  ||' '
  ||e.last_name NAME,
  d.department_name,
  l.city,
  l.state_province
FROM employees e
JOIN departments d
ON e.department_id = d.department_id
JOIN locations l
ON d.location_id = l.location_id;
/