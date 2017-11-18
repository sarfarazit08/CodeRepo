/// <reference path="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.5/angular.min.js" />

//Create the module
var myApp = angular
			.module("myModule", [])			
			.controller("myController", function ($scope) 
			{
			
				$scope.message = "AngularJS Tutorial";
		
				///
				var employee = {
					firstName: 'MD',
					lastName: 'Sonu',
					gender: 'Male'
				};

				$scope.employee = employee;
				
				///
				var country = {
                        name: "India",
                        capital: "Delhi",
                        flag: "india-flag.png"
                };
                
				$scope.country = country;
					
				///
				var staffs = [
					{ name: 'MD Sonu', gender: 'Male', dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 'Male', dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 'Male', dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 'Female', dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 'Female', dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 'Other', dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 'Female', dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 'Other', dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 'Male', dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.staffs = staffs;
				
				
				///
				var countries = [
					{ name: 'India', cities: [ { name : 'Delhi'},  { name : 'Mumbai'},  { name : 'Kolkata'}]},
					{ name: 'UK', cities: [{ name : 'London'},  { name : 'Birmingham'}, { name : 'Manchester'}]},
					{ name: 'USA', cities: [{ name : 'New York'},  { name : 'Washington'},  { name : 'Chicago'},  { name : 'Houston'}]},
					{ name: 'UAE', cities: [{ name : 'Mecca'}, { name : 'Medina'}, { name : 'Jidah'}]},
					{ name: 'Australia', cities: [ { name : 'Melbourne'}, { name : 'Sydney'}]}
					
				];

				$scope.countries = countries;
				
				///
				 var technologies = [
                    { name: "C#", likes:0, dislikes:0 },
                    { name: "ASP.NET", likes: 0, dislikes: 0 },
                    { name: "SQL", likes: 0, dislikes: 0 },
                    { name: "AngularJS", likes: 0, dislikes: 0 }
                ];

                $scope.technologies = technologies;

                $scope.incrementLikes = function (technology) {
                    technology.likes++;
                };

                $scope.incrementDislikes = function (technology) {
                    technology.dislikes++;
                };
	
			
				///
				var interns = [
					{ name: 'MD Sonu', gender: 'Male', dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 'Male', dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 'Male', dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 'Female', dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 'Female', dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 'Other', dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 'Female', dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 'Other', dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 'Male', dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.interns = interns;
				$scope.rowLimit = 3;
				
				
				///
				var colleagues = [
					{ name: 'MD Sonu', gender: 'Male', dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 'Male', dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 'Male', dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 'Female', dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 'Female', dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 'Other', dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 'Female', dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 'Other', dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 'Male', dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.colleagues = colleagues;
				$scope.sortColumn = "name";
				
				
				///
				var friends = [
					{ name: 'MD Sonu', gender: 'Male', dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 'Male', dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 'Male', dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 'Female', dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 'Female', dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 'Other', dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 'Female', dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 'Other', dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 'Male', dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.friends = friends;
				$scope.sortCol = "name";
				$scope.reverseSort = false;

				$scope.sortData = function (column) {
					$scope.reverseSort = ($scope.sortCol == column) ? !$scope.reverseSort : false;
					$scope.sortCol = column;
				}

				$scope.getSortClass = function (column) {

					if ($scope.sortCol == column) { 		return $scope.reverseSort ? 'arrow-down' : 'arrow-up';	}

					return '';
				}
				
				///
				var records = [
					{ name: 'MD Sonu', gender: 'Male', dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 'Male', dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 'Male', dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 'Female', dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 'Female', dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 'Other', dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 'Female', dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 'Other', dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 'Male', dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.records = records;
				
				///
				var empList = [
					{ name: 'MD Sonu', gender: 'Male', dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 'Male', dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 'Male', dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 'Female', dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 'Female', dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 'Other', dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 'Female', dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 'Other', dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 'Male', dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.empList = empList;
				
				$scope.search = function (item) 
				{
					if ($scope.searchText == undefined) {
						return true;
					}
					else {
						if (item.city.toLowerCase().indexOf($scope.searchText.toLowerCase()) != -1 ||
							item.name.toLowerCase().indexOf($scope.searchText.toLowerCase()) != -1) {
							return true;
						}
					}

					return false;
				};
								
				///
				var tblRecords = [
					{ name: 'MD Sonu', gender: 1, dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 1, dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 1, dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 2, dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 2, dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 0, dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 2, dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 0, dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 1, dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.tblRecords = tblRecords;
				
								///
				var persons = [
					{ name: 'MD Sonu', gender: 1, dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 1, dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 1, dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 2, dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 2, dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 0, dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 2, dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 0, dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 1, dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.persons = persons;
				
				var teachers = [
					{ name: 'MD Sonu', gender: 1, dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 1, dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 1, dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 2, dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 2, dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 0, dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 2, dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 0, dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 1, dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.teachers = teachers;
				
				var engineers = [
					{ name: 'MD Sonu', gender: 1, dateOfBirth  : new Date ('10/03/1989'), city : 'Kolkata'	, salary : 35800 },
					{ name: 'MD Imran', gender: 1, dateOfBirth  : new Date ('08/10/1988'), city : 'Hyderabad'	, salary : 25500 },
					{ name: 'Monu Shukla', gender: 1, dateOfBirth  : new Date ('11/02/1989'), city : 'Benaras' , salary : 65500 },
					{ name: 'Soniya Nargis', gender: 2, dateOfBirth  : new Date ('02/14/1992'), city : 'Delhi' , salary : 16000 },
					{ name: 'Priya Jinde', gender: 2, dateOfBirth  : new Date ('10/14/1989'), city : 'Pune'	, salary : 40000 },
					{ name: 'Rehana Sharma', gender: 0, dateOfBirth  : new Date ('07/09/1991'), city : 'Hyderabad' , salary : 30000 },
					{ name: 'Ayesha Parveen', gender: 2, dateOfBirth  : new Date ('02/04/1981'), city : 'Bangalore' , salary : 30500 },
					{ name: 'Rohan Narang', gender: 0, dateOfBirth  : new Date ('03/08/1983'), city : 'Pune' , salary : 26800 },
					{ name: 'Sohail Bazwa', gender: 1, dateOfBirth  : new Date ('01/07/1986'), city : 'Aurangabad' , salary : 12300 }
				];

				$scope.engineers = engineers;
				$scope.view = 'lib/table.html';
	
			});