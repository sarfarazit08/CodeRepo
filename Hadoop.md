# Hadoop

## What? Why ? How Hive Works

### What is Hive , What was the Motivation and Used Cases 

Apache Hive is a popular SQL interface for batch processing on Hadoop. Hadoop was built to organize and store massive amounts of data Hive gives another way to access Data inside the cluster in easy, quick way.

Hive  provides a query language called HiveQL that closely resembles the common Structured Query Language (SQL) standard.  Hive  was one of the earliest project to  bring higher-level languages to Apache Hadoop. Hive Gives ability to  Analysts and Data Scientists to access data with out being expert in Java . Hive gives structure to Data on HDFS making it data warehousing platform. This interface to Hadoop not only accelerates the time required to produce results from data analysis, it significantly broadens who can use Hadoop and MapReduce. Let us take a moment to thank Facebook team because Hive was developed by the Facebook Data team and, after being used internally, it was contributed to the Apache Software Foundation .Currently Hive is freely available as an open source software from Apache. 

+ SQL for Hadoop
+ HQL# No need to be expert in Java
+ Easier to Learn and Many People Know already
+ Structure to Data on HDFS (Hadoop Distributed File System)
+ Thank you Facebook
+ Open Source Project managed by ASF ([Apache Software Foundatin](https://www.apache.org/))

### Used cases of Hive

Hive is typically used to place Large amount of Unstrctured/Semi structured data on Hadoop and build Structure of it. Hive is best suited for batch jobs over Large Set of data for example WebLogs, Network Router logs. Analysts would be able query data on Ad-hoc basis to Data Analysis. Current stable version of hive is 2.3.2 (24th Jan,18).

### What Hive is not. Hive is not a Database  

Let us understand difference between RDBMS and HIVE. 

|RDBMS|HIVE|
|-|-|
|RDBMS|Not RDBMS|
|RDBMS Stores Data | Hive uses Data which is on Hadoop and does not store actual data|
|RDBMS support for both OLTP AND OLAP | HIVE IS FOR OLAP |
|Supports transactions|Does not Support Transactions|
|Support update/delete on column and table level|No support for Update/Delete Command on column level|
|for low latency | for high latency|

Hive in traditional is used for large scale volume. Hive is best suited for data warehouse applications, where there is no need for  real-time responsiveness to queries are not required.

Hive looks very much like traditional database code with SQL access. However, because Hive is based on Hadoop and MapReduce operations  Hive is more used for batch processing. Hadoop is intended for long sequential scans, and because Hive is based on Hadoop, you can expect queries to have a very high latency (many minutes). Latency for hive queries is high for even for small jobs which means that Hive would not be appropriate for applications that need very fast response times.

In this Sample Table : 

|Name|Comedy|Documentary|Horror|Inspiration|
|-|-|-|-|-|
|JO|10|20|30|40|
|NAD|20|30|40|50|
|SAM|30|40|50|60|
|FED|40|50|60|70|

if we want to delete SAM Rating on Documentary, in a RDBMS Table, we can run update/Delete command to Update/ delete it, where as in Hive we cannot update/Delete a particular value. This kind of transactions are not supported in Hive. But Hive supports Overwrite of the entire table or appending additional Data to this table. Let us proceed to discuss Hive Architecture.

Hive is not 100% SQL. HQL is limited in the commands it understands. Not all SQL commands work on Hive,  for example, Updates and deletes are not supported. 













2. What Hive is Not 
3. Hadoop Recap 
4. Hive Architecture 
5. Different Modes of Hive 
6. Hive Server 2 Concepts and Recap of Section 1 
#### Quiz 1. Concepts - Quiz 
    
## Installation , Configuration and Demo on Hive

7. CDH, CM and VM 
8. How to Download VM and Hive Demo 
9. Hive Shell Commands 
10. Different Configuration Properties in Hive 
11. Beeswax 
12. Install and Configure MySQL Database 
13. Install Hive Server 2 
#### Quiz . Hive Quiz -2 
    
## Working on Hive

14. Databases in Hive 
15. Datatypes in HIve 
16. Schema on Read and Schema on Write 
17. Download Datasets 
18. Internal Tables 
19. External Tables 
20. Partition 1A 
21. Partition 1B 
22. Bucketing 1A 
23. Bucketing 1B 
#### Quiz 3. Quiz on Tables 

## Hive Implementations in Real Time Projects

24. Hive In Real Time Projects 
25. Auditing in Hive 
26. Troubleshooting Infra issues in Hive 
27. Troubleshooting User issues in Hive
#### Quiz 4. Quiz on Troubleshooting
    
## Thank you and Project as Exercise
28. Thank you 
29. Project 
    
