# Git Basics

## Brief History

* Version Control System (VCS)
* Source Code Management (SCM)

## Most popular Version Control Systems

1. Source Code Control System (SCCS)
	* 1972, Closed Source, Free with Unix
	* Developed by AT&T
	* Kept fisrt version and applied subsequent changes to get to the final version
	* tracking for changes happened for single file at a time
	* only one person was allowed to modify a file at a time

2. Revision Control System (RCS)
	* 1982, Open Source, Cross-Plateform
	* Much faster than previous systems
	* Kept recent version and applied subsequent changes to get to the previous versions
	* tracking for changes happened for single file at a time
	* only one person allowed to modify a file at a time
	
3. Concurrent Versions System (CVS)
	* 1986-1990, Open Source, Cross-Plateform
	* Much faster than previous systems
	* Kept recent version and applied subsequent changes to get to the previous versions
	* tracking for changes happened for single file at a time
	* Multiple persons were allowed to modify a file (concurrently) 
	* Introduced the idea of `Code Repository` (Remote Repository)

4. Apache Subversion (SVN)
	* 2000, Open Source, Cross-Plateform
	* Much faster than previous systems
	* Kept recent version and applied subsequent changes to get to the previous versions
	* Multiple persons allowed to modify a file
	* Tracking for changes happened for files, file groups and directory as a whole	
	* Allowed saving of non-text files i.e binary files, images etc.
	

Git is the open source Distributed Version Control System (DVCS). 

* Keeps track of file and directory changes
	* tracks text changes in the files
	* used to manage scource codes

* Communication to Central Server is not required
	* It is faster
	* No single point failure
	* No need of Network access

* Encourages collaboration and participation
	* `forking` of projects
	* Independent development

## Git underlying structure (Three-Tree Architecture)

<table>
<tr><th>Directories</th><th>File Status</th></tr>
<tr><td>Working Directory</td><td>Changed</td></tr>
<tr><td>Staging Directory</td><td>Staged</td></tr>
<tr><td>Repository</td><td>Commited</td></tr>
</table>



> Finding the git installed directory 
* `which git`

> Check installed version of Git 
* `git --version`

# Git Configurations

> System Level Configuration 
* `git config --system`

> User Level Configuration 
* `git config --global`
* `git config --global user.name "<username>"`
* `git config --global user.email "<email>"`

> Changing the git command window color for syntax highlighting 
* `git config --global color.ui true`

> Project Level Configuration 
* `git config`

> To check the config settings 
* `git config --list`

> Get Git Help 
* `git help`

> Get Git Help for log
* `git help log`

> Check Git Status of files/directory between Repository->Staging Directory->Working Directory(could be remote or local)
* `git status`

> Initialize a fresh new Git repository 
* `git init`

# Adding list of tracked files for commit
It actually adds the files from Working Directory to Staging Directory.
Adding a new file or changed/modified file takes the same command.

> Add all tracked files 
* `git add .`
or
* `git add --all`

> Add only text files which are tracked 
* `git add *.txt`
or
* `git add "*.txt"`

> Add only files which are tracked and specified by the names 
* `git add <file1> <file2>`

# Discarding tracked files if we don't want to stage it

> Discard single tracked and specified by the names 
* `git checkout -- <file1>`

> Discard multiple tracked and specified by the names 
* `git checkout -- <file0> <file1> <file2>`

# Unstaging files if we don't want to commit it 
Reverts back the file status from Staging `Directory to Working Directory`.

> Unstage single file
* `git reset HEAD <file>`

> Unstage multiple file
* `git reset HEAD <file1> <file1>`

# Viewing what changed in the file(s) between `Working Directory and Repository`
To view changes that has/have been done to file(s) between current and previous version we use `diff` command.
> Get the difference for all files
* `git diff`

> Get the difference for a single file
* `git diff <file>`

# Viewing what changed in the file(s) between `Staging Directory and Repository`
To view changes that has/have been done to file(s) between current and previous version we use `diff` command with `staged` or `cached`.
> Get the difference for all files which are staged
* `git diff --staged`

> Get the difference for all files which are staged (*valid till Git version 1.6*)
* `git diff --cached`

> Get the difference for a single file which are staged
* `git diff --staged <file1>`

> Get the difference for a single file which is staged (*valid till Git version 1.6*)
* `git diff --cached <file1>`

> Get the difference for multiple files which are staged
* `git diff --staged <file1> <file2>`

> Get the difference for multiple files which are staged (*valid till Git version 1.6*)
* `git diff --cached <file1> <file2>`

# Committing Files
To persist the changes, which we've done to files, into repository we run commit.
> Commit without any message 
* `git commit`

> Commit with a message 
* `git commit -m "<Description of the changes done to files in present tense!>"`

> Commit with a message 
* `git commit -a -m "<message>"`

# Checking Commit Logs

> Commit log has following items 
* Commit identifier (a long alphanumeric string)
* Author of the commit
* Date of the commit
* Message/Label of the commit

> Check commit log
* `git log`

> Limit the commit logs to five most recent logs
* `git log -n 5`

> Commit logs since/until a date
* `git log --since=2017-05-25`
* `git log --until=2017-05-25`

> Commit logs by author
* `git log --author="sarfaraz"`

> Commit logs by Global Regular Expression (grep)
* `git log --grep="Init"`

# Deleting files from `Repository` and tracking them

### Method - 1 : 
* If files is already deleted from repository manually from files system then it needs to be tracked for `staging` and then `commit`.
* To do that we run the `rm` command. 
* In this method we could have files in the recycle bin/Trash in case we want to restore it.

> Track single deleted file
* `git rm <file1>` 

> Track multiple deleted files
* `git rm <file1> <file2>` 

> Track all deleted files
* `git rm .` 

#### Note: Run `commit` to track and persist the removed changes. 

### Method - 2 : 
* If files are not deleted from repository manually then we can simply run the `rm` command and 
it takes care of `file deletion` as well as `staging` in just one step. 
* Then we can `commit` those changes.
* In this method files can't be restored as it performs `Shift + del`.

> Track single deleted file
* `git rm <file1>` 

> Track multiple deleted files
* `git rm <file1> <file2>` 

> Track all deleted files
* `git rm .` 

#### Note: Run `commit` to track and persist the removed changes 

# Moving and Renaming files

Moving and Renaming files are basically synonymous in Git. 

### Method - 1 : 
* If files is already renamed in repository manually from files system then we need to do as follow:
	* add the untracked file(s) using `add` command
	* remove the deleted file(s) using `rm` command
* It then automatically stages the file when it realizes that added and removed file(s) content are matching (>50%) and marks it as 'renamed`
* This method is a two step process and is sutable if we've to rename multiple files.

> Track single renamed file
* `git add <file1>` 
* `git rm <file1>` 

> Track multiple renamed file
* `git add <file1> <file2>` 
* `git rm <file1> <file2>` 

#### Note: Run `commit` to track and persist the renamed changes. 

### Method - 2 : 
* If files is not renamed in repository manually from files system then we need to do as follow:
	* move the untracked file(s) using `mv` command	
* It `renames` the file as well as `stages` the file(s) in a single step.
* This method is a single step process and is sutable if we've to rename a couple of files.

> Rename/Move single file
* `git mv <old_file_name> <new_file_name>` 

> Rename/Move multiple files
* `git mv <old_file_name1> <new_file_name1>` 
* `git mv <old_file_name2> <new_file_name2>` 

> Moving file to a different directory
* `git mv <old_file_name> New_Folder/<new_file_name>` 

#### Note: Run `commit` to track and persist the renamed changes. 



git add docs/*.txt
git add docs/ 

git rm --cached <file> 



---Branching---

git branch
git branch <Branch name>
git checkout <Branch name>
git checkout -b <Branch name>

---Merging Branches---
git merge <Branch name>

 #fast forward merge
 #Merge by 'recursive' strategy

---Resolving merge conflicts---
checkin merged branches:
git branch --merged
git branch --no-merge

---Removing Branch---

git branch -d <branch name> 
git branch -D <branch name> #forced delete


