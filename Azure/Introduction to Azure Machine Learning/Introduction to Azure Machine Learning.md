# Introduction to Azure Machine Learning

<img src=”./resources/studio.png” alt=”Azure Machine Learning Studio” />

### Why should we use Azure Machine Learning Studio?
+ A cloud based environment where we build our predictive analytics experiments.
+ All you need is a browser
+ No software to install
+ No development environments to setup
+ No hassle of software download, install and configurations
+ A simple to use drag and drop interface like MS Visio.
SQL Server types will surely notice the similarity to SSIS. (Because these groups worked together to create AMLS)
+ Tons of samples to get you started.
+ Tons of algorithms built in for our use.
+ Integrated with R. (R is a programming language and software environment for statistical computing and graphics supported by the R Foundation for Statistical Computing)
+ This is a machine learning tool for the rest of us.
+ Analyze data of scale. We can easily connect our experiments to big data stores inside Azure Data Lake.
+ Deploy machine learning models in minutes.

<img src=”./resources/communication.png” alt=”communication” />

### Data Science - a way to obtain useful insights to data.
Analytic Spectrum - a way to divide all analytics into 4 categories. They are:
+ Descriptive - What happened?
+ Diagnostic - Why did it happen?
+ Predictive - What will happen?
+ Prescriptive - What should I do about it?
Azure Machine Learning - is a service that a developer can use to build predictive analytics models (using training datasets from a variety of data sources) and then easily deploy those models for consumption as cloud web services.
<img src=”./resources/summary.png” alt=”summary” />
+ Data Science is the practice of obtaining useful insights from data.
+ The rise of Big Data has brought more attention to predictive analytics.
+ Machine learning is really about calculating the probabilities of an event happening.
+ Data Science draws from various disciplines. (Mathematics, Statistics, Machine learning... etc.)
+ Analytics can be classified into one of four categories. Descriptive, Diagnostic, Predictive and Prescriptive. The most sophisticated of these is prescriptive and the least is descriptive.
+ Organizations can now incorporate often free data from outside their organization to make decisions.
### The high level steps to our data science are: 
+ Define a business problem
+ Acquire and prepare the data
+ Model it
+ Deploy it
+ Monitor model's performance.
### Most algorithms can be placed into **six** categories. 
+ Classification
+ Clustering
+ Regression 
+ Simulation
+ Content Analysis 
+ Recommenders
### Azure Machine Learning Studio in Details 
+ We will need to navigate to [Azure Machine Learning Studio](https://studio.azureml.net/) in order to create a login to Azure Machine Learning Studio.
+ There's a very well design tour that I recommend you watch when you initially log in.
+ We can import out data by clicking on the plus symbol in the left hand corner and choosing dataset from the menu on the left hand side of the screen.
+ Experiments we create are saved as drafts.
+ Web Services give us the ability to publish our model so it can be used or consumed by others.
+ Trained models are models that you've saved as completed models.
+ Experiments are composed of data sets and modules.
+ When we choose a module or dataset we have properties of that module or data set available to us on the right hand side of the screen.
+ When we choose run we are executing all the datasets and modules in our experiment.
+ When we create our model we are creating an experiment.
+ A dataset is data that's been uploaded to Azure Machine Learning Studio.
+ A module is an algorithm you use when building your predictive model.
#### There are 5 basics steps to creating an experiment.
1. We need to get the data.
2. We need to Pre-process the data.
3. We need to define the features.
4. Choose, Apply and Train Algorithm
5. Predict over the new data.
In its most simple form within a confusion matrix there are two possible predicted classes. Yes or No.
### Glossary
Experiment - The entity you create when building your models.
Datasets - Data that has been uploaded to Azure Machine Learning Studio.
Modules - Algorithms you can use to build your predictive models.
Confusion Matrix - A table that is often used to describe the performance of a classification model
True Positive - These are cases in which we predicted yes (they have the disease), and they do have the disease.
True Negative - We predicted no, and they don't have the disease.
False Positive - We predicted yes, but they don't actually have the disease.
False Negative - We predicted no, but they actually do have the disease.
Accuracy - How often is the classifier correct?
Precision - When it predicts yes... how often is it correct?
