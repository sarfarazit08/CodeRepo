# BizTalk Developer Interview Questions and Answers

Questions and answers on different BizTalk topics can be found in the following articles:

+ Schema
+ Map
+ Orchestration
+ BizTalk Application
+ BAM
+ Pipeline
+ Visual Studio - Biztalk Development
+ BRE
+ XSLT
+ Helper Class
+ Adapter
+ Functoid
+ EDI
+ BizTalk Database
+ HL7
+ ESB Toolkit 

## Schema

#### What is the purpose of a document schema?

+ The schema is basically a contract of your message and defines it.
+ XML Schema definition (XSD) language defines the structure of an XML instance message
+ Schema describe the structure of data in relational tables.
+ In the context of XML, a schema describes a model for a whole class of documents.

#### BizTalk Server supports four types of schemas:

+ XML schema: 
    + XML schema defines the structure of a class of XML instance messages.
    + This type of schema uses XSD language to define the structure of an XML instance message
+ Flat file schema
    + A flat file schema defines the structure of a class of instance messages that use a flat file format either delimited or positional or some combination thereof.
    + Because the native semantic capabilities of XSD do not accommodate all of the requirements for defining the structure of flat file instance messages—such as the various types of delimiters that might be used for different records and fields within the flat file
    + BizTalk Server uses the annotation capabilities of XSD to store this extra information within an XSD schema. BizTalk Server defines a rich set of specific annotation tags that can be used to store all of the required additional information.
+ Envelope schema
    + A special type of XML schema.
    + Used to define the structure of XML envelopes, which are used to wrap one or more XML business documents into a single XML instance message.
    + When you define an XML schema to be an envelope schema, a couple of additional property settings are required, depending on such factors as whether there are more than one root record defined in the envelope schema.
    + You can create an envelope schema in all of the same ways that you can create an XML schema for a business document. You can create a schema from a well-formed XML envelope instance message, or from Document Type Definition (DTD) or XML-Data reduced (XDR) representations of the envelope schema. Or, you can create a new schema, either in conjunction with other schemas or not. Because envelope schemas are generally much smaller and less complicated than most business document schemas, creating new envelope schemas is usually a viable alternative.
    + To define a schema as an envelope schema, you need to set the Envelope property of the Schema node to the value Yes. When you define an envelope schema, you should point the envelope's Body XPath to the parent node that contains only the child element. In order for the XML assembler to use the envelope, the parent node must not contain any other elements.
    + When you set Envelope property to Yes, it means that the actual message content of the XML instance message (called the body of the message) is present somewhere inside the root Record node of this schema, as specified by the Body XPath property of that node. Therefore, you must also set additional properties based on a variety of conditions:
    + If an envelope schema has a single root, you must set the Body XPath property for that root.
    + If an envelope schema has multiple roots and the Root Reference property is not set, you must set the Body XPath property for all roots.
    + If an envelope schema has multiple roots and the Root Reference property is set, you must set the Body XPath property of the corresponding root Record node. You can optionally set the Body XPath property for the remaining roots.
    + Regardless of whether an envelope schema has a single root or multiple roots, setting the Root Reference property is not required.

+ Property schema.
    + It describes context properties and is used with within BizTalk Server for property promotion.
    + It consists of only child node under a root node.
    + Property promotion is the process of copying specific values from deep within an instance message to the message context.
    + From the message context, these values are more easily accessed by various BizTalk Server components.
    + These components use the values to perform actions such as message routing.
    + Promoted property values can also be copied in the other direction, from the more easily accessible message context back into the depths of the instance message, just before the instance message is sent to its destination.
    + A property schema is a simple version of a BizTalk schema that plays a role in the process of copying promoted properties back and forth between the instance message and the message context.

#### What is the purpose of an envelope schema?

An envelope schema is a special type of XML schema. Envelope schemas are used to define the structure of XML envelopes, which are used to wrap one or more XML business documents into a single XML instance message. When you define an XML schema to be an envelope schema, a couple of additional property settings are required, depending on such factors as whether there is more than one root record defined in the envelope schema

#### What is the purpose of a Flat File schema?

+ A flat file schema defines the structure of a class of instance messages that use a flat file format, either delimited or positional or some combination thereof. Because the native semantic capabilities of XSD do not accommodate all of the requirements for defining the structure of flat file instance messages—such as the various types of delimiters that might be used for different records and fields within the flat file. 

+ BizTalk Server uses the **annotation capabilities of XSD** to store this extra information within an XSD schema. 

+ BizTalk Server defines a **rich set of specific annotation tags** that can be used to store all of the required additional information.

#### What is the target namespace for schema?

Target Namespace is to schema what a namespace is to .Net Object and root node as a class name.

#### Is it possible to create a custom data type and use it in a schema?

Yes, it's possible to create custom data types and it can be used across the schema.

#### Can schema have two nodes with the same name and different data types?

Yes, as long as they are not in the same scope.

#### Can schema have multiple root nodes?

Yes, a schema (XSD) can have multiple root nodes. In case you have a schema with multiple root nodes you will end up with multiple message types declared in BizTalk, one for every root node. So when you want to create a message you will need to specify exactly which message type you are going to use!

#### Is it possible to include and import in a single schema?

Yes, it is possible, both are the ways to utilize already existing schema. The only condition is the schema which is included should have same TargetNamespace or no namespace.

#### By default, what is the data type of elements in a schema?

xs:string

#### What is the difference between Group Max occurs, Group Min Occurs and Max occurs, Min Occurs?

These are all node properties.
+ Group Max Occurs: Specifies the maximum number of times that to the underlying group content of the selected All Group node can occur.
+ Group Min Occurs: Specifies the minimum number of times that the underlying group content of the selected All Group node can occur.
+ Max Occurs: Specifies the maximum number of times that the element corresponding to the selected Record node can occur.
+ Min Occurs: Specifies the minimum number of times that the element corresponding to the selected Record node can occur.

#### What is BlockDefault property used for?

Use the BlockDefault property **to prevent or restrict the types of derivations** that can be used in instance messages for all data types defined by the schema being edited.

#### What is a canonical schema?

+ A canonical schema is a design pattern, which is applied within a s**ervice oriented paradigm**.
+ Used to establish the **loose coupling** between systems within BizTalk server context. Through performing the transformation of messages from one system to canonical schema and from the canonical schema to message of another system, systems have no direct relation with each other. 
+ The canonical schema can also be viewed as an i**nternal schema** in BizTalk.
+ Helps in structuring your solution through best practice of creating separate projects for maps, orchestrations, internal and external schemas.
+ It reduces the number of transformations you need. you can create a map to your canonical schema for each inbound schema and then a map from your canonical schema to each outbound schema. e.g., if three types of incoming messages needs to be mapped to three types of outgoing messages you will only need to build and maintain six maps instead of nine.

#### What is the correlation property schema?

+ Correlation types define a **set of properties** on which you will be **correlating messages**.

+ These can be any **properties which were previously defined in a property schema** and deployed with some BizTalk Project including **system** properties deployed with the **GlobalPropertySchemas** which is installed as part of the base BizTalk install. 

+ A **correlation set** defines a **set of properties and values** for these properties that a **message must contain to be processed** by a particular **orchestration**.

#### Difference between Flat File Schema and XML schema?

+ A flat file schema defines the structure of a class of instance messages that use a flat file format, either delimited or positional or some combination thereof. 
+ Because the native semantic capabilities of XSD do not accommodate all of the requirements for defining the structure of flat file instance messages—such as the various types of delimiters that might be used for different records and fields within the flat file—BizTalk Server uses the annotation capabilities of XSD to store this extra information within an XSD schema. BizTalk Server defines a rich set of specific annotation tags that can be used to store all of the required additional information. See MSDN Different Types of BizTalk Schemas

An XML Schema is basically a contract of your message and defines it. The XML Schema definition (XSD) language defines the structure of an XML instance message, and this is the intended purpose of XSD, such schemas use XSD in a straightforward way. See MSDN Different Types of BizTalk Schemas

#### Can we have schema without a target namespace? What will be its MessageType?

Yes, we can have a schema without target namespace and it's message type will be the Root node.

#### Which property is only available for the flat file schema?

Custom Date/time property is only available for flat file schema.

#### What is the Message?

Each message in BizTalk Server is considered a multi-part message and is made up of zero or more parts. Each message with one or more parts has one of these parts identified as the body part. Each part consists of a binary chunk of data which can represent an XML document, a flat file, a serialized .NET class, or other binary stream of data. You use the body part of the message to identify the type of the message that can be used for routing.

####  What is the difference between BizTalk (Schema) Editor and BizTalk Schema Generator?

BizTalk Editor resides within the Microsoft Visual Studio shell. Some of the functionality within BizTalk Editor relies upon existing user interface elements within the Visual Studio shell.

BizTalk can automatically create the schema from DTD, well-formed XML, and XDR. To do this schema generator is used.

#### How is schema generator invoked?

Right click the project in Solution Explorer and select **Add Generated Items > Generate Schemas**.

#### What is InstallWFX.vbs script?

It is a script which when run installs the BizTalk Schema Generator. It is used when generating schema from existing items. It's likely to get error first time or after updates "WFX to XSD Schema generation module is not installed". Then this script can be used to install the schema generator.

#### Can "EDI" be a part of Namespace?

It can be but it should be avoided in the projects that uses BizTalk EDI engine as during run time there can be conflicts with this and expected results might not be seen.

#### Is it possible to promote XML record of ComplexContent?

No. To promote XML record its ContentType property should be set SimpleContent.

#### What is the maximum length allowed for promoted properties?

255 characters

#### What is the maximum length allowed for Distinguished fields?

It can be of any length, no limits.

#### How to create an XPath alias to a field which can be used in decision making in Orchestration?

Distinguished field is a XPath alias to the field.To create it , right click the element-->Promote-->Show promotion-->Add

#### What is element?

An element in a schema designates a specific location in the schema where new elements or attributes can be added. When BizTalk uses the schema to process a message containing unknown elements or attributes in the designated location, the schema will still consider the message valid.

#### What is the Root Node?

It's a node within a BizTalk Server schema that represents the outermost XML element in the business document specified by the schema.

#### How BizTalk engine identifies a unique schema?

BizTalk uses a combination of namespace#rootnode to define the schema type of a message, thereby making a MessageType unique (for example: http://mynamespace.com#MyRootNode). In other words, BizTalk uses this combination to identify and resolve schemas references.

#### How BizTalk engine performs a validation of an instance of the message against the Schema?

By default, BizTalk Server will examine only the namespace and the root node name of a message to identify and validate the schema, and will not detect extra elements in the message body. To perform a deep validation of a message format, you have to create a Custom Pipeline with the XML Disassembler component. See more here .

#### What are encoding options available used by BizTalk when creating schema?

There are various options but BizTalk always uses UTF-16 encoding for their schemas. See more.

#### Does BizTalk add any namespaces when creating schema?

Yes. http://schemas.microsoft.com/BizTalk/2003
and http://www.w3.org/2001/XMLSchema
are added by BizTalk when creating a schema. See more.

#### ow is schema namespace added by BizTalk when creating schema?

By default, the BizTalk Editor will set the namespace of a schema to http://ProjectName.SchemaName.

#### What is the difference between XSD and DTD?
 Difference between XSD and DTD are listed below:
+ XSD are written in XML.
+ XSD support data types.
+ XSD support namespaces.
+ XSD is extensible to future additions.
+ XSD is richer and more powerful than DTDs.

## MAPS

#### What are maps?

Maps are graphical representations of XSLT (Extensible Stylesheet Language Transformation) documents that allow us to perform, in a simple and visual manner, transformations between XML messages. A map file basically is the XML file that defines the correspondence between the records and fields in one schema and the records and fields in another schema. You create a map when you want to transform or translate data that you receive or send from one schema to another. See more here.

#### Can we have map without any links on it?

Yes. But to do so custom XSLT is to be provided to the map.

#### How do we provide/include custom XSLT in the map?

Click on the map grid and in properties tab specify the location where custom XSLT is stored against the property "Custom XSLT path".

#### Is it possible to have a global variable in a map?

Yes. Choosing inline code allows us to declare global variables outside the method declaration. These are accessible throughout the map from within all inline code scripting functoids.

#### What are the places map can be used?

Receive Port, Orchestration, Send Port

#### Can we have map chaining on ports?

Not on the same port, only the first that matches the received message type will execute. You can have a map execute on a Receive Port and then have another map execute on the Send Port (or have multiple maps in an Orchestration, or use the ESB Toolkit to achieve this.

#### What is limit of maps on ports?

There is no limit.

#### Is it possible to generate XSLT from the map?

Yes, right click the map and select Validate Map. The output window will include "The output XSLT is stored in the following file:" and the location of the XSLT file.

#### Is it possible to use untyped message in the map?

No

#### Is it possible to create map for a schema with unknown structure?

Yes its possible. It can be done by including the element in the map.

11. Where are transformations more flexible?

+ Transformations are more flexible and fast when they are executed from a send or receive port.
+ We can replace map on the ports without any development effort.
+ But if we replace map in orchestration we have to recompile and redeploy the orchestration assembly.

12. Is it possible to override the mapping of Mass copy?

+ It can be done on line by line basis. Example a field need to be passed a current date, then have the Date functoid placed a link to destination field this will override mass copy.

13. Is there limit on number of pages on Map grid?

There is no limit, it depends on the requirement and complexity of the map.

14. Why should pages to be added to Map Grid if all can be done on a single page?

Multiple pages enable you to organize your links so that any one page does not become too cluttered and confusing.It is also very helpful to label the pages and the links.

15. Is there a way to add custom logic required in a Map?

Yes it's possible and it can be done with the help of Scripting functoids or creating the custom functoids.

16. Can value from Orchestration variable be passed to the destination field in the Map?

+ Yes it can be done, by creating a new schema which will contain fields for capturing values from Orchestration variable and with the help of LoadXml to load the values. 
+ This schema can be used along with an other source schema and mapping can be done. 
+ The variable also can be passed inside the Assign shop in an expression.

17. Is it possible to have map with n incoming messages to n outgoing messages?

+ Yes, but only inside Orchestrations! This type of maps must be created using the Transform shape within an Orchestration. + Orchestration Editor creates an envelope schema which includes all nested message schemas.

18. Is it possible to have map with n incoming messages to 1 outgoing messages?

+ Yes. And the only place that map can be created with multiple schemas is in a Transform shape within an Orchestration.

19. Is it possible to have map with 1 incoming message to n outgoing messages?

+ Yes, but only inside Orchestrations! This type of maps must be created using the Transform shape within an Orchestration.

20. Can the graphic map representation and external XSLT be used in single map?

+ No. As everything which we see in Map grid (links, functoids) are overwritten when external XSLT is used.

21. Can we debug Map just like .Net code?

+ Yes. Right click the map to debug and select "Debug Map".

22. What is a .btm File?

+ .btm is a BizTalk Server map file.

23. What is the BizTalk Mapper Designer and where I can find it?

+ It is a tool that runs within the Microsoft Visual Studio .NET environment after you install BizTalk Server.
+ We use the Mapper to create and edit maps.

24. What kind of transformation can we accomplish using maps?
 [Controversial]

+ Using maps we can accomplish Semantic Transformations. 
+ This type of transformation usually occurs only in BizTalk maps but also can be performed inside pipelines. 
+ Here the document maintains the same syntax that is represented (XML), but changes its semantics (data content).
+ This type of transformation is typically one-way, since that's when we added and aggregate small parts of the information, that compose the document into another differently document, we may miss important details of its reconstruction.

25. What are grid pages and how many can we have?

+ The mapper grid plays a critical role in the definition of maps, containing the links and functoids that control how data in a source instance message is transformed into an instance message that conforms to the destination schema.
The grid view can have multiple layers, called grid pages, allowing you to organize complex maps into logical subdivisions of mappings. BizTalk 2010 no longer has the limitation of 20 grid pages that exist in the previous versions of the product.

26. Is it possible to link the output of a functoid placed on the right side of the map grid with a functoid placed on the left side of the map grid?

No it is not possible as grid follows left to right precedence. An output link of the first functoid has to be placed into an input of the second functoid.

## Orchestration

1. How are messages created in an orchestration?

You construct a message any time that you introduce a message into your orchestration, either by receiving it or by assigning values to a message variable (see MSDN Constructing Messages ). There are several ways to create a new instance of a message in an orchestration, see Michael Stephenson blog post Message Construction in an Orchestration .

2. Where is information about promoted properties stored?

The information about the promoted properties is extracted and stored in the bts_DocumentSpec table in the Management database.

3. What is message metadata?

The message metadata is called Context Properties and on receiving the message, both the adapter and the pipeline will add information to the context.

4. Can we use message metadata in Orchestration?

Yes

5. How does Orchestration subscribes to messages?

In Orchestration, the first Receive shape is responsible for creating a subscription. Following two properties are involved in it,
	+ Message : This tells what message this Orchestration is subscribing to
	+ Activate : This tells to consume the message when found in a MessageBox

6. Design patterns in Orchestration?

One of the best practices when implementing orchestrations is to use orchestration patterns when possible. These patterns are basically design pattern, which is a general reusable solution to a commonly occurring problem within a given context of BizTalk orchestration. This article will provide some useful resource links to aid you in using patterns when implementing an orchestration. See TechNet Wiki articles BizTalk Server 2010: Orchestration Patterns and BizTalk: Enterprise Integration Patterns.

7. Types of messages?

Two types of message
	 + Typed message : A message created in Orchestration is bound to the schema
	 + Untyped message : A message is bound to System.Xml.XmlDocument instead of the schema.

8. How to load message in a variable?

It can be done using the LoadXml method. Say xmlDoc is a variable then following is done to load employee message.
xmlDoc.LoadXml("JoeSmith");
9. Can recursion be achieved in Orchestration?

No
10. What is binding?

The term binding refers to the configuration of orchestration ports in order to control the creation of subscriptions and/or promoted properties. Binding is used to control how messages will be routed to or from orchestration ports by the subscription mechanism.
11. To which scope compensation block can be added?

A scope configured as Atomic or Long running can have compensation blocks added, but scopes that are configured with no Transaction type cannot.
12. Is it necessary for all .Net components being called from orchestration to be serializable?

Yes it is necessary (good practice) for all .Net components being called to be serializable. If not then Atomic scope is to be used which has its own limits.
13. Is it possible : Orchestration A calls another Orchestration B and vice versa?

No it is not, since it forms cyclic dependency.
14. What is XLANG and where it is used?

XLANG/s can be viewed as a messaging language with some of the expression capabilities of C#. However, code is not portable between XLANG/s and C#. The language is used for orchestrations. XLANG/s statements generally fall into one of two categories: simple statements that act on their own, such as receive or send, and complex statements that contain or group either simple statements or other complex statements, such as scope,parallel, and listen. The semantics embodied in XLANG/s are a reflection of those defined in the Business Process Execution Language for Web Services (BPEL4WS) specification published by Microsoft, IBM, and BEA for the definition of business process semantics. See MSDN XLANG/s Language .
15. Can we prevent Orchestration from entering a suspended state?

Any exception which is not caught within the exception handlers of the orchestration causes the orchestration instance to be moved to the Suspended state. By applying the appropriate error handling in an orchestration it can be prevented entering the Suspended state.
16. What is persistence point?

At various points within a running orchestration the state can persist. See MSDN Persistence and the Orchestration Engine .
17. XMLDocument is non-serializable still it's called without atomic scope with no error, why?

It is the only exception to the requirement of types for variables having to be serializable and treated as special case. See more here
18. What is the maximum number of properties that can be used in correlation set?

The correlation set can have a maximum of three properties used for correlation on the receive shapes.
19. Can an Atomic scope can have an exception handler of their own?

No, it can only have a Compensation Block.
20. Pro's and Con's of Direct binding?

Pro's:
a. Loose coupling
b. Not bounded to any physical port (explicitly)
Con's: c. Can lead to subscribing to messages published by another publisher
21. Can orchestration use components other than listed in Toolbox?

Yes. It is possible to use components like pipeline, business rule policy, .net component etc.
22. When is convoy used?

The convoy is used to receive multiple messages in sequence or parallel to achieve a goal/result.
23. Is it possible to enforce Orchestration to behave in singleton way?

Yes it is possible with the help of correlation.
24. Where is BTS.SPID and BTS.ReceivePortID used?

It is used in Specify Later port binding option. In this model the orchestration ports are bound to messaging ports using BTS.SPID,BTS.ReceivePortID or other related properties.
25. When is property "Synchronized=true" used?

When a variable is shared across the branches of parallel shape.
26. What is the maximum number of branches that can be used in a parallel shape?

There are no limitations on the number of branches which can be used in a parallel shape.
27. Which language does expression shape support?

Expression shape allows for writing XLANG/S statements that provide C# -like coding capabilities.
28. What is relation between Orchestration instance and correlation?

Correlation is the process of matching an incoming message with the appropriate instance of an Orchestration.
29. What are the ways to add properties in context?

Promoting a node to a property field means to make a node value available in the context of the message.Adapters and pipeline components write in the context.
30. What is the difference between written property and promoted property?

Promoted properties can be used as criteria in message routing while written properties cannot. Property field is a Promoted Property in the context. Distinguished field is a Written property in the context.
31. What is correlation type?

A correlation type is a list of properties that eventually populates with values for use in routing messages.
32. What are conditional persistence points?

The Receive shape, Listen Branch and Delay shape are conditional persistence points.
33. What are Scopes used for?

Scopes are used for following reasons:
. To configure transaction (long running and atomic)
a. To handle exceptions
b. To trigger compensating logic
34. Which shapes are used to implement "AND" and "OR" situation in Orchestration?

Parallel Action shape is used for a AND situation whereas Listen shape is used for OR situation.
35. Which scope can have an Exception Handling?

A scope configured with the transaction type of None or Long running can have exception handling added but not Atomic scope.
36. Is it possible to get an exception object from General Exception?

No. General exception in BizTalk is similar to writing a Try-Catch block but without the exception object thus not possible to get the exception object.

37. What's the main difference between Call and Start Orchestration?

Calling an orchestration will use the same thread to run another orchestration while using Start Orchestration will create a new thread to run the started orchestration.

A Call Orchestration returns the control back to the caller. A Start Orchestration shape starts the orchestration in a non-deterministic way.

As a conclusion, Calling an Orchestration will be synchronous operation where the caller waits for a response, while Start Orchestration is asynchronous operation. See more here .

38. What are the different types of transactions available for orchestration?

Unlike traditional programming, BizTalk Server supports two distinct types of transactions: atomic and long-running. See more here .
39. When a persistence point occurs at the Orchestration level?

The engine will save the state of an orchestration in the following circumstances:
	 + Send Shape (after a message is sent)
	 + Start Orchestration Shape
	 + Suspend Shape
	 + End of a Transactional Scope (atomic or long-running)
	 + An Orchestration Debugger breakpoint is hit
	 + Orchestration Engine determines that the instance needs to be dehydrated
	 + When the Orchestration Engine is shut down; through the controlled shutdown of the host or abnormal circumstances. The engine tries to persist but if that fails, the Orchestration instance will resume from the last successful persistence point.
See more here .
40. Can persistence point occur in the Delay or Receive shape?

Yes, but only if the Orchestration Engine determines that the instance needs to be dehydrated.
41. Is it possible to use Message Assignment shape and Transform shape individually?

No, it is not possible, Transform and Message assignment shape must run under construct shape.

## BizTalk Application

#### What is MessageBox?

MessageBox is a SQL server database along with messaging agent. See MSDN MessageBox .

2. What is the purpose of MessageBox?

+ Store all messages and context received.
+ Stores all subscriptions.
+ Stores all Host Queues.

3. What happens to the messages coming into MessageBox?

+ Checking the subscription table is the First thing when messages come in MessageBox and a copy of the message is sent to the subscriber.

4. How does MessageBox treats messages without subscriber?

+ The message is suspended when there are no subscribers found for it.

5. How many receive locations can a single receive port have?

+ Receive port can have any number of receive location.

6. Types of subscription in BizTalk?

+ Two types of subscription viz. - Activation and Instance

Instance subscriptions are removed from the message box while Activation subscriptions remain active as long as the orchestration or send port is enlisted.

7. Is it possible to have various ports with the same name in two applications?

+ No. The names of the various ports must be unique, not just inside an Application but for the whole BizTalk group.

8. In which state can a send port does not subscribe to a message?

+ In Unlisted state send port does not subscribe to any messages and no messages will be sent through the port.

9. What could be the reason for having multiple receive locations inside one Receive port?

+ The reason for having multiple receive locations inside one Receive port is to have the ability to receive different messages from different locations and having BizTalk treat them as if they were received from the same place and/or had the same message type.

10. How can we check what's going on inside BizTalk Server?

+ The group hub gives the user an overview of what is currently going on inside BizTalk.

11. Can a send group be a part of multiple send group?

+ No only static send ports can be part of send group.

12. Ordered delivery on send port has serious performance impact, why?

+ Because only one thread can submit messages through the port and each message has to wait for messages through the port and each message has to wait for the message before it can be processed.

13. Ordered delivery does not have an effect even after it is set, when this might happen?

+ When back up transport is also applied.

14. Can a message in a MessageBox be changed?

+ Messages in BizTalk are immutable after constructed and the message is considered constructed after it is placed into the MessageBoxDatabase.

15. What happens when we run MSI package?

+ When we run MSI packages, it will register the application with Windows Operating System and then load any related assemblies in the Global Assembly Cache.

16. In how many ways can we do the BizTalk Application deployment?

+ BizTalk Application deployment can be done using the following:
a. Deploying from Visual Studio
b. Building a Microsoft Installer (MSI) package that can be exported or imported between environments.
c. Using command line-based tools such as MSBuild and BtsTask.
d. Using community frameworks, such as BizTalk Deployment Framework and NANT.

17. How it's possible to work with several pipelines as soon as new Application is created?

+ BizTalk.System is already referenced in all new applications, as a result of this we can work with several pipelines as soon as a new application is created.

18. What happens to message when all subscribers have received their message?

+ BizTalk will no longer need to hold on the message and the message will be removed from BizTalk.

19. What can be done to avoid loss of messages in a scenario where we know beforehand unavailability of the destination system, but source system is publishing messages?

+ In this scenario we can stop the send port bound to the destination system. This way the messages will lie in a queue inside Messagebox. Subsequently, we can start the send port when the destination system is available.

20. When do Error Report properties get promoted?

+ When Failed message routing is enabled and if an error occurs at the port, then the message will have all the regular context properties unprompted and instead have some error-specific context properties promoted - all in the ErrorReport Namespace e.g. ErrorReport.ErrorType, ErrorReport.ReceivePortName etc.

21. Which is the first step to enable Subscription?

+ A filter on the send port is the first step to enable subscriptions in BizTalk.

22. Can Application be in start state when host is Offline?

+ Yes. But this application will not function properly.

23. When don't filters on send port apply?

+ If a send port is directly bound to an orchestration port, then filters do not apply.

24. How to apply maps on send port group?

+ Maps can't be applied to Send Port Group.

## BAM

1. What is BAM and whats the benefits of using it?

Business Activity Monitoring (BAM) is used to monitor business milestones and key metrics in near real-time throughout a process in BizTalk. Business Activity Monitoring (BAM) is a module in BizTalk that captures business data and process milestones to allows business decision makers to gain insight of their in-flight processes. Using BI tools to derive up-to-date metrics and key performance indicators from the BAM databases, users can forecast process trends and monitor processes in real-time. BAM also provides a mechanism to alert users to situations that require their intervention to prevent undesirable outcome or to encourage a beneficial result.

2. Is it possible to integrate BAM installed on server1 and BizTalk installed on server2?

Yes its possible with a condition that BAM server has to be part of the BizTalk group. See more here.

3. What is the difference between TrackingProfile DB and DTADB?

Both are same and terminology is used interchangeably.

4. What is an Activity and an Alert?

BAM Activities identify the milestones and tracking data an individual is interested in tracking. Milestones are the steps in an activity that are measured in time, and tracking data are the key data points in a process you are interested in tracking (such as a customer ID or name).
BAM alerts allow you to configure and receive alerts related to specific changes in business data. Alerts are set up per BAM view.

5. What is ContinuationID?

Continuation is the ability to contribute to a single BAM activity from different applications by using two different unique identifiers as the ActivityID. For example, in one part of a business process, a customer’s PO number might be used to track an activity. In another part of the process, an internal order fulfillment number might be used to track the same activity. You could enable continuation and relate the PO number and the order fulfillment number, so that both parts of the process could add information to the same activity.

6. What is TDDS?

Tracking Data Decode Service or TDDS, is a service that moves event data from the MessageBox database to the BAM Primary Import database. This service processes and persists both Business intelligence and BizTalk Health Monitoring data.

7. What are the various types of BAM Interceptors available?

The BAM Interceptor is an object that lets you instrument your application to capture data of interest. See morehere .
	 + BAM WCF interceptor: BAM can capture data from SOAP envelope in a WCF request, response or fault message. The data is specified using interceptor configuration (IC) file (XML file created by developer). The service’s app.config must be modified to load the BAM components at runtime.
	 + BAM WF interceptor: like WCF Services, BAM can also capture milestones from WF Activities. Am IC file is used to specify the data that must be captured. BAM components must also be loaded at runtime.

8. What is Activity Relationship?

An activity relationship exists when an activity relates to one or more other activities. An example of this is having multiple Shipment activities related to a single Purchase Order activity, or one Shipment activity containing items from two Purchase Order activities.
To indicate that two activities are related, you need to know both names and have the corresponding ActivityIDsin memory in order to call AddRelatedActivity. This API creates the link between the corresponding activity records. See more here .

9. What is a BAM View?

A BAM view is a representation of the milestones and business data tracked in one or more activities on the BAM Portal.

10. Can we have multiple views created on single Activity?

Yes its possible to have multiple views on single Activity.

11. Where BAM collects raw tracking data?

BAM collects raw tracking data from the BAMPrimaryImport (BAM Primary Import) Database.

12. Is BAM Tools a prerequisite for EDI/AS2 Runtime in BizTalk Server 2010?

That depends on the functionalities (features) you want to install, but for me the correct answer is no. See morehere .

13. How many database are used by BAM?

BAMPrimaryImport, BAMStarSchema, BAMAnalysis, BAMArchive, BAMAlertsApplication and BAMAlertsNSMain.

14. What is this tool BM.EXE and why do I need it?

BAM Management utility or “bm.exe” provides for end-to-end management and deployment of BAM. You can use the BAM utility to perform the following tasks:
	 + Consume BAM definition and BAM configuration XML as input.
	 + Deploy the run-time infrastructure on the server, which includes the BAM Primary Import database, BAM Star Schema database, BAM Analysis database, and corresponding Data Transformation Services (DTS) packages.

15. Where the data came from, what the BAM Data Sources?

The most commonly data sources used with BAM are:
	 + BizTalk Application
	 + BAM API
	 + WCF Services (WCF Interceptor)
	 + WF Workflows (WF Interceptor)

16. What is BAM Portal?

It is a Web-based feature that consists of a collection of ASP.NET pages, it portal provides real-time, end-to-end visibility into a business process.

17. It is required to track custom code used in application, which can be used TPE/BAM API or both can be used?

TPE can't be used here as it can only be used to capture data from BizTalk artifacts, thus BAM API have to be used.

18. Is there any shape in Orchestration which can't be tracked?

Yes. There are some shapes like:
a. Terminate
b. Throw Exception
c. Group
d. Loop
e. Message Assignment
f. Suspend
g. Transform

19. What are various event streams used in BAM API?

Orchestration Event Stream (OES)
Asynchronous, participates in BizTalk orchestration transactions.
Buffered Event Stream (BES)
Asynchronous, high throughput, some latency.
Direct Event Stream (DES)
Synchronous, no latency and directly written to the BamPrimaryImportDb.
Messaging Event Stream (MES) Asynchronous, participates in BizTalk Server pipeline transactions.

20. Is it possible to apply BAM on the retry mechanism of Send Port?

No, because the code execution for retry happens in adapter which is out of the BAM tracking scope.

## Pipeline

1. Why do we need a custom pipeline when we have default pipelines?

BizTalk Server provides a few out of the box pipeline components. For instance the S/MIME components for encrypting or decrypting messages. In case you need to do some pre or post processing on a message and the functionality is not offered through the provided pipeline components you will need to build your own custom pipeline component. The pipeline component(s) can then be used within a custom pipeline. See also TechNet Wiki Article BizTalk: List of Custom Pipeline Components.

**Recieve pileline stages :**

+ Decode
+ Dissamble
+ Validate
+ Resolve

**Send pileline stages :**

+ Pre-assemble
+ Assemble
+ Encode


2. What is the maximum message size supported by XML send an XML receive pipeline?

This depends on infrastructure specifications (CPU, Memory, Disk) and on specific (possible) bottlenecks in your Microsoft BizTalk Server system (see MSDN How BizTalk Server Processes Large Messages ). While BizTalk Server imposes no restriction on message size, practical limits and dependencies might require you to minimize the size of your messages because large messages require more processing resources (see MSDN Message Considerations ).

3. What is the minimum number of components allowed in pipeline stage?

Minimum is zero components, example PassThru pipeline.

4. What is the maximum number of components allowed in pipeline stage?

All stages in the pipeline can take maximum of 255 components, except the assemble stage that has a maximum of one.

5. Does Flat file assembler pipeline component validates the incoming XML message?

No

6. What is a .btp File?

.btp file is a BizTalk Server pipeline file.

7. How many states have the Receive Pipelines and the Send Pipelines?

The receive pipeline consists of four stages
	 + Decode Stage: This stage is used for components that decode or decrypt the message.
	 + Disassemble Stage: This stage is used for components that parse or disassemble the message.
	 + Validate Stage: This stage is used for components that validate the message format.
	 + Resolve Party Stage: This stage is a placeholder for the Party Resolution Pipeline Component.
Regarding to the send pipelines, they consist of three stages:
	 + Pre-assemble Stage: This stage is a placeholder for custom components that should perform some action on the message before the message is serialized.
	 + Assemble Stage: Components in this stage are responsible for assembling or serializing the message and converting it to or from XML.
	 + Encode Stage: This stage is used for components that encode or encrypt the message.

8. Is there any Visual Studio Wizard to create custom pipeline components?

Yes there is. The Pipeline Component Wizard is intended to ease development of pipeline components used within a BizTalk Server environment. Supports both C# and VB.NET. See more here .

9. What's the difference between Default Pipelines and Custom Pipelines?

When you create a new application, the default pipelines are created and deployed by default and appear in the Microsoft.BizTalk.DefaultPipelines assembly in the References folder for every BizTalk project. The default pipelines cannot be modified in Pipeline Designer. These pipelines can be selected when configuring a send port or receive location in BizTalk Explorer.

Pipelines and pipeline components present out of the box can do most of the tasks for you. But sometime specific message processing or messaging requirements encourage developers to develop custom pipeline components. You can create three types of pipeline components: general, assembling, and disassembling. Each of the three types can additionally implement probing functionality. Each type of pipeline component has an associated interface that must be implemented for the component to be plugged into the BizTalk Messaging Engine; the pipeline interfaces that distinguish the types of components are IComponent, IAssemblerComponent, and IDisassemblerComponent. A custom pipeline component is just a plain .NET class that implements several BizTalk interfaces.

10. Is there an error handling functionality to handle error on pipelines?

Yes. Error-handling functionality called error reporting which enables handling pipeline errors. Error reporting isspecified on receive and send ports within the BizTalk Administration console.

11. When is filter used to create a subscription?

Filters are used to create subscription when orchestrations are not part of the scenario.

12. Which property is required when using Flat file Disassembler component?

Setting the Document Schema property is required, all other properties are optional.

13. What if Document Schema property is not specified when using Flat file Disassembler component?

A runtime schema discovery will be attempted, Biztalk Server attempts to determine the correct flat file schema to assemble the message with, based on the namespace and the root node of the message.

14. Which API is used to implement Pipeline?

To implement pipeline we have to use the API in the Microsoft. BizTalk. Component. Interop namespace.

15. What are types of pipeline components?

+ General
+ Assembling
+ Disassembling
+ Probing

16. Why attributes are added to class while developing a custom component?

To indicate that the component is a custom pipeline component and in which stage it can be used, couple of attributes are added to the class.
[ComponentCategory(CategoryTypes.CATID_PipelineComponent)] -- This attribute tells that the component is cutom pipeline component
[ComponentCategory(CategoryTypes.CATID_Any)] -- This attribute tells that the component can be used at any stage
OR
[ComponentCategory(CategoryTypes.CATID_DisassemblingParser)] -- This attribute tells that the component can be used only on Disassemble stage

17. Custom Component is not visible in Toolbox, even after adding the assembly to GAC?

Just adding assembly is not sufficient, it needs to be added to component dll at location : C:Program FilesMicrosoft BizTalk Server 2010PipelineComponents and then reset the toolbox, it will be visible and ready to use.

18. What interfaces are used in developing a general custom pipeline component?

IBaseComponent,IComponentUI,IComponent,IPersistPropertyBag

19. What interfaces are used in developing a custom dis-assembler component?

IBaseComponent,IComponentUI,IDisassemblerComponent,IPersistPropertyBag

20. What interfaces are used in developing a custom assembler component?

IBaseComponent,IComponentUI,IAssemblerComponent,IPersistPropertyBag

21. What interfaces are used in developing a custom Probing component?

IProbeMessage

## Visual Studio - Biztalk Development

1. What purpose does Visual Studio serve?

Development for BizTalk Server is done through Visual Studio (depends on BizTalk version). Visual Studio has templates for BizTalk artifacts like orchestration, pipelines, schemas and maps, so a BizTalk solution can be created (design time) and deployed to the BizTalk runtime. Besides artifacts .NET development can be done in creating pipeline components, custom functoids, custom adapters, and .NET helper classes to aid in orchestrations. As a BizTalk professional Visual Studio is your friend and required to build BizTalk solutions.

2. What is strong name key?

A strong name ensures that each assembly name is unique. Each assembly in your BizTalk project requires a strong name in order to deploy successfully. See also MSDN How to Configure a Strong Name Assembly Key File .

3. How is strong name key generated?

At the command prompt, from the folder where you want to store the key file, type the following command, and then press ENTER: sn /k file_name .snk. In Visual Studio Solution Explorer, right-click the project and then clickProperties. Click the Signing tab and choose Browse in the Choose a strong name key file drop down box. See also MSDN How to Configure a Strong Name Assembly Key File.

4. Difference between Build and Rebuild?

Build means compile and link only the source files that have changed since the last build, while Rebuild means compile and link all source files regardless of whether they changed or not. See also MSDN Building and Cleaning Projects and Solutions in Visual Studio .

5. What are the actions in order to deploy from Visual Studio?

+ Sign the project with strong name key
+ Give the name to the Application

6. Can I create or configure Receive Ports or Send Ports through Visual Studio?

That depends of the BizTalk Version/Visual Studio that you are using! In previous version you could create and configure port through the BizTalk Explorer view in Visual Studio, but since BizTalk Server 2010 the BizTalk Explorer view was removed from Visual Studio.

7. What is a .btproj File?

.btproj is a Visual Studio BizTalk project file.

8. Are all the BizTalk development tools embedded in Visual Studio?

No. Indeed BizTalk Mapper Editor, Schema Editor, Orchestration editor and Pipeline editor are embedded in Visual Studio. However BAM and BRE tool are not embedded.

9. Why we get the error "Unexpected error writing metadata to file "?

It is a known issue of Visual Studio. Visual Studio will not successfully compile a project if it would result in an assembly larger than 75 megabytes (Mb).

10. Where can we see assembly information in Visual Studio?

AssemblyInfo.cs contains information about assembly, like name, description, version, etc. It can be located under Project-->Properties-->AssemblyInfo.cs

11. What is Build Order and can it be changed?

Build Order is the sequence in which the projects will be build when the whole solution is build and yes it can be changed.

12. What is option Clean used for?

Clean Solution is used to delete any intermediate and output files (mostly assemblies). With only the project and component files left, new instances of the intermediate and output files (mostly assemblies) can then be built.

13. What is a Business Rules Engine?

A run-time inference engine that can link highly readable, declarative, semantically rich rules to any business objects (.NET components), XML documents, or database tables. It can evaluate rules against facts and initiate actions based on the results of that evaluation.

14. What is the tool that I need to use to create Business Rules?

You need to use the Business Rules Composer. This is a graphical tool used for authoring, versioning, and deploying policies and vocabularies.

15. What is a Business Rule Language?

It is a rule markup language in XML format for declarative rule definitions.

16. How can I execute a Business Rule in my orchestration?

Using the Call Rules Shape. See more here .

17. What is used to create new vocabulary definition?

The Vocabulary Definition Wizard is used to create vocabulary definitions.

18. What is a Policy?

A policy is a logical grouping of rules. You compose a version of a policy, save it, test it by applying it to the facts, and, when you are satisfied with the results, publish it and deploy it to a production environment. See more here .

19. Is it possible to change Business Rule policy after it was published?

No. After policies are published it can't be edited. But if there is a need to have a change in policy then new version of policy is to be created.

20. Does rule composer have provision of adding ELSE logic?

No, there is no provision of adding ELSE but else logic can implemented with extra IF.

21. What is Long term fact and Short Term fact?

The fact is the user data to which rule conditions are applied. At design time a fact is a reference to that data.
Facts have two categories – Short Term Facts and Long Term Facts. Consider a loaning process of any Bank. We can think a “loan application” as short term fact. Short team facts are business information which changes per occurrence. On the contrary, “interest rates” do not change very regularly. This business information is steady and we can consider it a long term fact.

22. What is the difference between Publishing and Deploying the Rule?

Rule alone cannot be published or deployed, it has to be wrapped under Policy and then published and deployed. When a policy is deployed it is ready to use and can't be edited whereas when published, policy aren't ready for use.

23. Can we call policies from .Net code?

Yes. Firstly it needs to be declared (policy name which is to be called), passed in the fact instance and finally executed.

24. Can we call a specific version of Policy using Call rule shape in Orchestration?

No, as the call rules shape calls the latest version of the policy deployed.

25. What is purpose of BizTalkRuleEngineDb?

This database is a repository for:
	 + Policies, which are sets of related rules
	 + Vocabularies, which are collections of user-friendly, domain-specific names for data references in rules.

26. Is there limit for versions of policies?

No.

27. What is Rete Algorithm, does it have any relation with BRE?

Rete Algorithm is an efficient pattern matching algorithm for implementing production rule systems. BRE's inner working is based on the Rete algorithm.

28. How does it differ, calling the policy in Call Rules Shape and in Expression?

The Call Rules shape in the Orchestration calls only the latest version of the policy. To call an older (specific) version from within an orchestration, the Business Rules Framework APIs is used, which can be called from within an expression.

29. How to test specific rules (not all) defined under one policy?
 To be answered

30. What is XSLT?

XSLT or Extensible Stylesheet Language Transformations is a style sheet language for XML documents (stands for XSL Transformations), it defines the transformation rules of the messages.

31. Where does XSLT come into picture in BizTalk?

When a developer faces a complex mapping (problem) and to solve it requires a substantial amount of logic he/she can use custom XSLT. See TechNet Wiki article BizTalk Virtual Mapper VS Custom-XSLT.

32. What is Muenchian method?

The Muenchian Method is an algorithm for grouping of data used in XSL Transformations that identifies keys in the results and then queries all nodes with that key. It can be applied with custom XSLT within a BizTalk Map. See MSDN Blog Muenchian Grouping and Sorting in BizTalk Maps .

33. Which version of XSLT is supported by the BizTalk mapper?

BizTalk Mapper supports XSLT 1.0. Using XSLT 2.0 in BizTalk Mapper is not supported (See MSDN Creating Maps Using BizTalk Mapper ).

34. Can I use Custom XSLT inside a BizTalk mapper?

Yes, by making use of the scripting functoid.

35. Is it possible to exclude xml declaration in the ouptut file?

Yes. To exclude xml declaration, the attribute "omit-xml-declaration" is to be set as "yes."

36. Can the filter be applied to the output from the xml file?

Yes. It can be done by adding a criterion to the select attribute in the element.Filter operators which can be used are:
	 + =(equal)
	 + != (not equal)
	 + greater than

37. How to traverse through the repeating node the input file?

The XSL element can be used to select every XML element of a specified node-set.

9. Is it possible to have custom functions?

Yes, it can be done in script blocks which can be done using element.

10. Is it possible to use method from a assembly available in GAC?

It can be done using element and it has to be child of element.

## Helper Class

1. What is a helper class?

A .net helper class with the context of BizTalk is a class (library) that can support an orchestration with extra functionality. It can enhance an orchestration in tracing, error handling, caching, and serialization/deserialization. See TechNet Wiki article BizTalk Server 2010: .NET Helper Classes.

2. Where can the helper class be used?

.NET (helper) classes can be used inside an orchestration. See TechNet Wiki article BizTalk Server 2010: .NET Helper Classes.

3. A helper class which is not marked serializable , can it be used in Orchestration?

Yes, it can used in orchestration but in an atomic scope only.

4. Why is it required that helper class/.net assembly to be marked serializable?

When creating an assembly that will be used by BizTalk, it is appropriate to mark all classes as serializable. Since BizTalk is stateless and makes use of persistence points, which details are stored in BizTalk SQL Server databases by serializing all the data. Therefore non-serializable Classes or Types cannot be used directly in Orchestrations.

5. What does property "copy local" indicates?

"Copy Local" property indicates whether the assembly referenced should be copied into the local bin directory when a project is built.

6. Is it possible to create a .Net class variable in BizTalk if property "Use default constructor" is set to false?

Yes it is possible, in this case the variable will need to be instantiated in an Expression shape through the new keyword.

7. What is Gacutil.exe?

The Global Assembly Cache tool allows you to view and manipulate the contents of the global assembly cache and download cache. See MSDN GacUtil.exe .

8. Is there a way to automate the process of adding assembly in GAC?

Yes. Right click the project, go to properties and select Build Events
And add following in the Post-Build event command line: "C:Program filesMicrosoft Visual Studio 8SDKv2.0BinGacUtil.exe" -u $(TargetName)

9. Is helper class deployed like BizTalk application?

No, it is added to GAC on the machine where it is used.

10. Why helper class/.Net assembly doesn't list in the Resources of Application, in spite of having reference to it and used in the application?

Because resources are meant to hold only BizTalk resources.

11. How helper class or .net assembly is added to GAC?

With the use of gacutil.exe and following command:
gacutil /i assemblypath

12. There is a .net helper class which suits to a requirement (in Orchestration) of an application but it is Non-Serializable, how can it be used?

Below are the steps :
a. Add Reference
b. Make Orchestration as Long running
c. Add Atomic Scope
d. Add Expression shape
e. Orchestration variable of class inside scope
f. Instance of object inside the scope
g. Call method

13. What is an Adapter?

An adapter is a software component (COM or .NET-based) that enables you to easily send messages out of or receive messages in BizTalk Server with a delivery mechanism that conforms to a commonly recognized standard, such as SMTP, POP3, FTP, or Microsoft Message Queuing (MSMQ). As Microsoft BizTalk Server has evolved, the need for adapters that quickly enable connectivity with commonly used applications and technologies has increased. BizTalk Includes over 25 multi-platform adapters that simplify the integration with Line of Business (LOB) Applications (such as Siebel, SAP, JD Edwards, Oracle, and Dynamics CRM), database (Microsoft SQL Server, Oracle, DB2) and other technologies (Tibco, Java EE). (See more here )

14. What is required for a developer to create a custom adapter?

A developer can receive requirements for building a custom adapter in case there are no out-of the box or commercial available to fulfill certain functionality. This can be done by using the Microsoft Windows Communication Foundation Line of Business Adapter SDK. See MSDN Microsoft Windows Communication Foundation Line of Business Adapter SDK .

15. What is the purpose of Adapter?

Adapters are the components that enable the BizTalk to interface with the external communications protocol.They mediate between the protocol and the messaging pipeline in use.

16. Does an adapter write to content of the message?

No. The adapter only writes data in the context of the message which is further interrogated by another component of BizTalk.

17. What are the native adapters in BizTalk?

"Native" or "integrated" adapters in BizTalk are: FILE, FTP, HTTP, MQSeries, MSMQ, POP3, SMTP, SOAP, Windows Sharepoint Services, and the seven WCF adapters (WCF-WSHttp, WCF-BasicHttp, WCF-NetTcp, WCF-NetMsmq, WCF-NetNamedPipe, WCF-Custom, and WCF-CustomIsolated)
(MSDN Adapters in BizTalk Server , BizTalk 2010) or the ten WCF-based in BizTalk Server 2013 if you include WCF-BasicHttpRelay, WCF-NetTcpRelay, WCF-WebHttp and two other new ones SB-Messaging and SFTP adapter.

18. Which port do you need configure in a firewall for in and outbound traffic when using the FTP Adapter?

For the FTP adapter you will need to configure port 20 and/or 21. See MSDN Ports for the Receive and Send Servers .

19. What happens to file when message is suspended in a MessageBox?

The file adapter deletes the file from disk.

20. What does "Public address" property defaults to?

This property defaults to file://{Receive folder value}/{file mask value}. The literal prefix file:// is required so as to communicate the protocol in use. It is string from 0 to 255 characters.

21. What is the default value of Retry count and Retry interval (min)?

The default value is "5". This can be altered through the Advanced Options Tab of the Transport Properties of a Send Port. See MSDN How to Configure Transport Advanced Options for a Send Port .

22. What is an Adapter Handler?

An adapter handler is an instance of a BizTalk host in which the adapter code runs. When you specify a send or receive handler for an adapter you are specifying which host instance the adapter code will run in the context of. An adapter handler is responsible for executing the adapter and contains properties for a specific instance of an adapter. A default BizTalk Server configuration will create adapter handlers for all of the installed adapters, but you may want to create additional adapter handlers for purposes of load balancing or to provide process isolation for a particular adapter handler. (See more here )

23. What Is the Adapter Framework?

The BizTalk Adapter Framework offers a stable, open mechanism for all adapters to implement or access work from the BizTalk Server Messaging Engine. The interfaces described in the Microsoft.BizTalk.Adapter.Framework namespace enable adapters to provide a means to modify configuration property pages. It also is a means to import services and schemas into the BizTalk project. (See more here )

24. What you mean with Native Adapters and Custom Adapters?

Native adapters are those that are shipped with the product and there are more than 25 multi-platform adapters. But in some cases a BizTalk Server may need to transport messages to a specific custom application or use a protocol for which a native adapter does not exist. If you are unable to locate an adapter to support your communication requirements, BizTalk Server provides a framework for developers so that you can develop your own custom adapter.

25. I've heard the term connector in BizTalk. So what's the difference between an adapter and a connector?

Probably the same thing. In BizTalk, we can call a connector as a software component that enables you to easily exchange messages between BizTalk Server with different systems, i.e, it's an adapter- a communications service used to exchange documents with your trading partners or your internal systems.

26. What can we expect when Propagate fault message is enabled?

The fault message will be published to subscribing applications. If it is not enabled then any fault messages will end up being suspended and are available in the BizTalk Administration Console.

27. What is an Isolated Receive Adapter?

The receive adapter that is hosted in a process other than a BizTalk Server process. This adapter is created and controlled by an external process and it registers with BizTalk server at run time to submit messages.

28. What is journal queue?

The journal queue is a system queue that is automatically created when MSMQ is installed and is meant to contain copies of messages that are sent or received.

29. What is dead queue?

The dead letter queue is a system queue that is automatically created when MSMQ is installed and is meant to contain undelivered messages.

## Functoids

1. What is functoid?

The term functoids refers to predefined functions within the BizTalk Mapper tool set. Functoids support a number of useful translations and transformations.
We can consider functoids, as pre-defined functions that we can use to perform complex data manipulations and transformations. Typically on a map, the data is copied from source to destination by dragging links between elements of the two schemes. Functoids stays in the middle of these operations and apply an operation on the incoming data in order to transform them to the requirements of the destination. BizTalk Mapper Designer represents a functoid as a box in the middle of the link or links between the processing elements. As a point of interest, functoid is a term coined by Microsoft and is commonly described as “functions on steroids.”
2. What is required for a developer to create a custom functoid?

Basically you need to Create a new class library project using the .NET language of your choice and create a class derived from Microsoft. BizTalk. BaseFunctoids. However the easiest way is to use the BizTalk MapperExtensions Functoid Wizard. See more here .
3. Why would a developer create a custom functoid ?

Below scenarios can tempt developer to create custom functoid:
	 + When there is no out of box functoids which can be used to complete the logic.
	 + When the number of functoids used to implement the logic goes on increasing and becomes difficult to follow and manage.
4. What is the difference between Value Mapping and Value Mapping Flattening functoid?

	 + Value Mapping: When both the source and the destination schemas define parallel repeating structures between which the relevant data is mapped.
	 + Value Mapping (Flattening): When the source schema defines a repeating structure and the destination schema defines a flat structure, such that different instances of the repeating structure in the source schema are intended to be mapped into the unique elements in the flat structure in the destination schema.
5. How can you build an if-then-else construction with functoids?

To build if-then-else it will need any of the Logical functoid (depending upon the requirements, e.g., if value is to be matched then Equal Functoid) and a Value mapping functoid. The combination (Logical Functoid and Value Mapping Functoid) will repeat, firstly to implement IF condition and secondly to implement ELSE condition.

6. Is it possible to reuse method of a Scripting Functoid in other Scripting Functoid?

Yes, it is possible. To do so the method at first place should be declared as public and then it can be called from other scripting functoid.

7. What is Microsoft.BizTalk.BaseFunctoids.dll?

This DLL implements all the base classes which are needed to create a functoid.

8. What are the ways to integrate custom functoid into solution?

Custom functiods can be integrated into a solution using two ways (in both BizTalk.BaseFunctoid is derived):
	 + Directly by using inline code
	 + Indirectly by reference to a method in a class library deployed into the global assembly cache.

9. What can be done using Scripting Functoid?

Custom code or custom scripts can be added .

10. How many categories are functoids divided in Tool Box?

There are 9 categories available in Toolbox viz.,
	 + Advanced
	 + Conversion
	 + Cumulative
	 + Database
	 + Date and Time
	 + Logical
	 + Mathematical
	 + Scientific
	 + String

11. Can we concatenate 200 input parameters using String Concatenate functoid?

No. As the minimum input parameter accepted is 1 and maximum is 100.

12. How can we get the count of the repeating node or repeating element?

Record Count Functoid can be used here, the input to this is the looping record/element.

13. Is it possible to know the index of the current record in looping structure?

Yes with the use of Iteration functoid. Iteration functoid gives the index of the current record in a looping structure.

## EDI

1. What is EDI?

+ Electronic data interchange (EDI) is a document standard which when implemented acts as common interface between two or more computer applications in terms of understanding the document transmitted. It is commonly used by big companies for e-commerce purposes, such as sending orders to warehouses or tracking their order.

2. What are the things which make EDI solutions differ from standard XML solutions?

+ EDI solutions are on the same line as XML solutions but involved more complexities in schema, maps etc. Also few more things are to be done like setting up and configuring the trading partners (business profiles, parties, agreements etc.).

3. How to create the EDI schema?

+ BizTalk already ships with the standard EDI schemas. To use it we need to extract the schemas using the MicrosoftEdiXSDTemplates.exe file, located in the root of the XSD_SchemaEDI folder.

4. What is the default character set supported by EDI pipeline?

+ UTF-8 is the default Character set supported and it is used for run-time validation and applies only to EDI X12.

5. How does BizTalk resolves Agreement?

+ BizTalk requires the qualifier and identifier fields for sender and receiver in order to perform agreement resolution. It will match the values of ISA5, ISA6, ISA7, and ISA8 in the interchange header with those in the properties of an agreement.

6. When does fallback agreement properties come into the picture?

+ When BizTalk is not able to resolve the agreement, then it uses the fallback agreement properties.

7. It is required to use EDI Pipeline in the EDI solution, but I can't see in the options?

+ EDI pipelines are not included in the Application as XML and Pass Thru pipelines are available. A reference to the BizTalk EDI Application is to be explicitly added so as to use EDI pipelines.

8. What are the values which Segment Separtor Suffix and Segment Terminator Suffix can have?

+ Either of the following : None,CR,LF or CRLF

9. Are there a relation between EDI sending pipeline and Parties?

+ The EDI sends pipeline performs a party lookup by performing a series of steps to determine whether there is a match between the outgoing interchange and the properties of a party.

10. What are the options to release EDI Batch messages to destination?

+ There are four options which can be used as deciding factor and then release:
	 + Schedule : At regular intervals
	 + Maximum Number of Transaction Sets :Fixed number of transactions within an Interchange
	 + Maximum Number of Characters in an Interchange : Number of characters
	 + External Release Trigger : Whenever a Trigger Message is given to BizTalk

11. Is it possible to receive Multiple Interchanges in a Single Message and parse it?

+ Yes it's possible to receive multiple interchange in a single message and to parse it, the pipeline property calledDetectMID is to be set as True.

12. Can we access EDI message context properties in orchestration?

+ Yes it's possible. To do so reference to Microsoft.BizTalk.Edi.BaseArtifacts.dll should be added.

## BizTalk Database

#### What effect does creating a new Host have on the Database?

When the new host is created it results in a new entry in the Host table in the Management database and also a new Host queue in the MessageBox.

#### The MessageBox database holds all the messages that are processed, what about messaging Objects?

Messaging objects viz. Receive Ports, Receive Locations, Send ports, etc. are stored in the Management Database.

#### Is there any change in the database when the filter is added to Send port or when Activate property of Receive shape is set to true?

Yes. An entry is added in subscription table.

#### What databases are part of every solution?

BizTalk Server Management database, MessageBox databases, Tracking database, and SSO database are four database which are used by BizTalk server runtime operations. It is the component that encapsulates and abstracts the database component and is the interface used by BizTalk Server to interact with the MessageBox. The Message Agent is a Component Object Model (COM) component that provides interfaces for publishing messages, subscribing to messages, retrieving messages, and so on. This interface is the only mechanism used by other BizTalk Server components, including the adapter framework and orchestrations, to interact with the MessageBox.

#### Which service looks after known issues in the database?

Monitor BizTalk Server, this job scans the BizTalkMgmtDb, BizTalkMsgBoxDb and BizTalkDTADb database for any known issues, including orphaned instances.
+ How would you define database role in context to BizTalk?

The database is used to store the data about the Message and other data required for processing it, along with the help of SQL Server Agent Jobs.
+ Which SQL Agent job runs continuously?

MessageBox_Message_ManageRefCountLog_BizTalkMsgBoxDb is the job which runs continuously in spite of scheduled to run once per minute.
+ Messages without subscribers are removed, how?

MessageBox_Message_ManageRefCountLog_BizTalkMsgBoxDb determines when a message is no longer referenced by any subscriber. When no subscriber found it starts MessageBox_Message_Cleanup_BizTalkMsgBoxDb which removes the unused message.
+ Does implementing BAM require more database?

Yes. BAM Analysis, BAM Archive, BAMAlertsApplication, BAMAlertsNSMain, BAM Primary Import database and BAM Star Schema can be used to implement BAM solution.
+ Which database stores the configuration information for receive locations?

Single Sign-On database (SSODb) securely stores the configuration information for receive locations, other known secret information is stored in the BizTalkMgmtDb.
+ How many databases are used for implementing BRE?

In addition to the default 4 databases only one database, i.e. Rule Engine Database.
+ What are the options for upgrading BizTalk Server Database?

There are two ways for upgrading
1.In Place upgrade
2.Transfer Upgrade.
See More
What happens when HL7 accelerator is installed?


The installation of the HL7 accelerator results in one or more of these items, depending on the selection during installation:
+ Schemas : Contains the XSD representation of HL7 messages which are in flat file format in version v2.x
+ Pipelines : Converts HL7 messages in flat file format into XML on receive and XML to flat file when sending messages and validates the HL7 message
+ Adapter: Minimal Lower Layer Protocol (MLLP) adapter enables BizTalk to receive or send HL7-based messages, which BizTalk Server typically transports using the MLLP protocol. The MLLP adapter ensures that BizTalk Server and BTAHL7 are interoperable with HL7-based messaging applications.Generates acknowledgements for received messages
+ Tools and Utilities : Configuration Explorer, MLLP Test Tool, SDK, Logging framework
2. What does BTAHL72VXCommon project contains?


It contains Schema for MSH segent and HL7 acknowledgements.
3. What does BTAHL7231common project contains?


It contains the definitional schema referred to by all version 2.31 message schemas.
4. Is it mandatory to configure party for HL7?


Yes,You need to add a party for each application that sends data into BizTalk server.
5. Is it required to specify schema per pipeline?


Unlike default flat file DASM that BizTalk server provides, the HL7 does not require that a schema be specified per pipeline.
6. What consideration is to be taken while dealing with MSH entries?


Entries in MSH are case sensitive.
7. When does DASM generates acknowledgements?


If configured for Acknowledgement or if MSH.15 and MSH16 request them, the DASM generates one or more acknowledgements.
8. Why is it required to have party configured?


The HL7 parser is designed to check the party configuration for each HL7 message. It reads the MSH.3 and checks for whether a party has been defined. If it has then HL7 parser follows the configuration supplied via HL7 configuration explorer.
9. HL7 accelerator runs in which mode?


HL7 accelerator runs only in 32 bit mode. (64 bit support is available in BizTalk 2013).
10. Can we override values in the MSH segment of the outgoing message?


Yes, it is possible to override certain field values in MSH segment of outgoing message.
11. Can we alter the namespace in the MSH schema?


We can, but do not alter because the HL7 parser only looks for single MSH, the standard one that the HL7 accelerator provides.
12. What is difference between BTAHL72XReceive and BTAHL7XMLReceive?


Both are used to receive HL7 message but former one used to receive HL7 message as flat file and later one to receive HL7 message as XML.
13. What are the acknowledgement types defined by HL7?


The ACK code is found in the MSA-1 field of the ACK message. The following codes are supported by HL7:
+ AA – Application Accept
+ AE – Application Error
+ AR – Application Reject
+ What is ESB Toolkit and why do we need it?

BizTalk ESB Toolkit provides a set of services on top of the existing BizTalk Server 2010 architecture to enable service consumers and service providers to be partof a loosely-coupled but mediated environment. Using ESB toolkit, it helps to enable Dynamic Routing, Transformation and Exceptions handling and consideredto be a platform to realize a service-oriented architectureand by solvingthe problems of point-to-point service connectivity with the help of a common mediationlayer (the "bus").
+ What is the ESB Toolkit version shipped with BizTalk Server 2013 R2 ?

2.3
+ Can there be any drawbacks which you need to take care before deciding to implement ESB Toolkit ?

It is an security issue that can happen while doing ESB Toolkit setup in a multi server configuration. This happens when ESB Portal web application refused toforward the impersonated credentials to the SQL Server since it is on another server. An identity delegation rights should be given to the application pool. Referthis to know more details.
+ Can you highlight the features of ESB Toolkit?

Below are are some underline features of ESB toolkit:
#### Location & Version Transparency
#### Transport Protocol Conversion
#### Dynamic Data / Format Transformation
#### Lightweight Service Composition
#### Error Handling & Repair
#### Service Interactions Support
+ Does ESB Toolkit improves BizTalk performance?

ESB Toolkit doesn't address to improve run-time performance.
+ How you can use ESB Toolkit and BRE for BizTalk application development?

We can have BRE resolver to achieve more dynamic routing approach. Rules can be configured not only for transport or transformation but also for itinerary itself.
+ What are the ESB toolkit Core components?

#### Itinerary Services
#### Resolver, Adapter Provider Frameworks
#### Exception Management Framework
+ What is an Itinerary?

Itinerary (also described as "Routing slip") is a mediation Policy which can be attached to a message which comes to the ESB dynamically. Itinerary providespictorial view of message flow with On/Off Ramp
+ Can we encrypt Itinerary?

Yes, in fact visual studio default option is to enforce encryption. Since Itineraries may potentially contain sensitive configuration information, “Itinerary Encryption”was introduced to encrypt your itineraries with certificate before exporting them.
+ What is resolver, and can you list out the ESB toolkit provides?

A component which feeds run time configuration values to the Adapter provider the so that it can dynamically configure the Dynamic Adapter at run-time. It is a.NET component having a collection of entries which tells what values to use for various BizTalk components.
Example: STATIC, UDDI, XPATH, BRE, BRI, ITINERARY, ITINERARY-STATIC, LDAP
+ What are On/Off Ramps?

#### On-Ramp is receive location which provides esb context (Corresponds to Receive port)
#### Off-Ramp (typically dynamic) is send port with respect to esb context (Corresponds to the send port)
Refer MSDN Article for details

+ What is ESB Management Portal?

The ESB Management Portal provides views of fault information that make it easy to monitor, manage, and debug ESB applications. It also provides features thatyou can use to manage alerts, publish UDDI information, and administer the portal. To open the portal, navigate to http://localhost/ESB.Portal/. Refer MSDNfor details .
+ What is Routing Slip pattern?
 How ESB toolkit supports it?

Routing Slip pattern is widely used message routing pattern and used when a message is routed through a series of components in a pre-defined order (may beunknown during design time). ESB provides this pattern via Itinerary-based processing. Business rule can be used to select an Itinerary for a message dynamically. See How to in msdn .
+ Can we develop a custom itinerary resolver?

Yes, by implementing IResolverProvider interface. Refer Creating a custom resolver .
+ What is the use of Export Mode property in?

Export Mode property can be used to define where the service will execute.
Strict: ensures that the itinerary service executes in its prescribed container; itinerary has a stage property that specifies the pipeline in which the serviceexecutes.
Default: the itinerary service executes in the order prescribed, but not necessarily in the pipeline stage desired.
+ I can see my Itinerary in the EsbItineraryDb database and set the correct resolver connection string in pipeline but I still see error "The itineraryESBTransformServiceItinerary was not found in the repository. ", why?
?

The Itinerary need to be in the Deployed status in order to use it. To verify this, you can either check nStatuscolumn value "1?
 in Itinerary table or ItineraryStatus column in Visual Studio by selecting Model Exporter as Database.
You won't be able to call the itinerary in Published status.
+ Why there is no Itinerary status option when choosing XML Itinerary Exporter?

Because you have choosen to export your Itinerary in XML for moving it to different environment. Once you are importing it to the targeted environment, youhave option for "Publish" / "Deploy".
+ How to move itineraries from one environment to another (e.g. QA to Production)?

EsbImportUtil.exe utility tool is a good option used to publish or deploy the itinerary XML into the ESBItineraryDB database.
+ What is ESB Dispatcher?

It sets endpoint location properties for outbound message using esb resolution guidance.
+ Can you summarize a typical Message Life Cycle in ESB Toolkit?

On-Ramp -#### ESB Pipeline (ESB Context promotion) -#### Itinerary -#### MessageBox -#### Queue message for subscriber -#### Subscriber (Orchestration / Off-Ramp). Referthis MSDN Article for details
+ Can we On-Ramp / Off-Ramp message with messagebox?

Yes (with some trick), a message created within BizTalk Orchestration can promote properties with ESB context and published to MessageBox.
+ Can we perform multiple transformation in sequence inside Itinaries?

Yes, you need to add multiple Itinerary Services in sequence to achieve this.
+ How can you call an Orchestration inside the Itinerary?

Using Orchestration Service Extender.
+ What are the three commonly used promoted properties to subscribe correct message of an itinerary service?

ServiceName, ServiceState, ServiceType
+ What are the common patterns implemented in Itineraries?

Message Routing
-#### Message Router: determines the recipient of the message based on a set of conditions
-#### Content-Based Router: determines the recipient of a message based on message content
-#### Routing-Slip: a message must be routed through a series of components in a pre-defined order, which may not be known at the design time.
-#### Recipient List: a message is routed to one or more recipients (static / dynamic)
-#### Splitter : Breaking one message to multiple chunks
Message Transformation
-#### Translator : Solves the problem of translating incompatible data formats between two systems
-#### Normalizer : Solves the problem when messages received from different sources are semantically equivalent but format is different
-#### Content Enricher : Solves the problem by furnishing additional data to the received message required by target system
Service Mediation
-#### VETO / VETRO : Solves the problem using ESB pipelines for Validate, Enrich, Transform, Route, Operate
-#### Request-Response: Solves the problem of two way communication
Service Management
-#### Repair and Resubmit: Solves the problem with the use of ESB Management Portal
+ Is it possible to implement service chaining in itineraries (i.e. Sending a message to a service and feeding the response received from that service as input to the next service and so on...)?

Yes. It is possible in itineraries.
1. What jobs do you need to configure when you install BizTalk?

	 + The Backup BizTalk job (location of Full and Log backups). See Aspects of backup BizTalk Server
	 + The DTA Purge and Archive job (at least the location where you want to Archive Tracking data. See How to Configure the DTA Purge and Archive Job
After you have configured the jobs, don't forget to enable them!
2. What are thresholds?

From a BizTalk perspective, these are numeric values, which can be configured on your Hosts and host instances, and lead to Throttling situations once they are crossed. See Microsoft BizTalk Automatic Throttling

3. What is BizTalk Host Throttling?


Throttling is the process by which BizTalk Server ensures optimum performance and use of system resources (memory, threads, CPU etc.)
4. Why do you have automatic throttling states and what can it be used for?

To warn the BizTalk Administrator that BizTalk is under stress or something abnormal is happening to the environment, these may only affect certain hosts or all hosts in the environment depending on the throttling state. See Microsoft BizTalk Automatic Throttling

5. What does a “high available environment” mean?

BizTalk can be configured in that it uses a Failover- or Load Balanced cluster. By doing so, BizTalk uses several physical or virtual machines to spread the workload. In case one of the machines goes down, BizTalk is still able to process workload on the other machine(s). See BizTalk Server: High Availability Survival Guide

6. What is NLB?

This stands for Network Load Balancing. It's one of the possibilities to make IIS high available on machines where BizTalk is installed. BizTalk itself however has its own load balacing. Again see BizTalk Server: High Availability Survival Guide

7. What is Host Architecture?

A Host Architecture describes how BizTalk uses Hosts and Host Instances for spreading its workload. Normally you have Hosts for Receiving messages, Processing orchestrations, Sending messages and Tracking completed messages. See BizTalk Server: Host Architecture

8. How do you route messages by Receive Port name?

By adding a filter on a Send Port, which points to that Receive Port. See what can go wrong: BizTalk Message Based Routing: why is my file not transferred to the location of the Send Port

9. How do you measure performance for BizTalk?

By using PerfMon and configure counters for CPU, Memory, I/O, Throttling. Besides using Perfmon, you can use tools like PAL, SQLIO, SQLProfiler, and IOMeter. See MSDN Tools for Measuring Performance and BizTalk Server: Performance Tuning & Optimization.
10. Which are the four most important BizTalk databases?

	 + BizTalkMgmtDb (contains the configuration of a BizTalk Group)
	 + BizTalkMsgBox (contains the messages and work in progress)
	 + BizTalkDTADb (contains information about the completed processes)
	 + SSODb (contains credential information)
See BizTalk database: Survival Guide
11. What are the dangers of filters combined with Send Port Groups and multiple Send Ports?

There is the risk that Send Ports which are also used in Send Port Groups, pick up the message multiple times, leading to the danger that the message is processed multiple times, where it should be processed only once.
12. What needs to be backed up for a complete disaster recovery?

Besides the databases, the Master Secret Key and all application and programs on the BizTalk Machine. See MSDN Planning for Disaster Recovery .
13. What is an orphan message?

An orphaned messages is a message that has completed and finished its processing in the BizTalk message box however the information of this is not updated in the tracking database and will hold space in the tracking database until manually deleted or updated.
14. What is a zombie message?

A zombie messages is a messages that arrives after an orchestration has finished, and can no longer reference back to the orchestration of it origin, see MSDN Zombies in BizTalk Server .
15. What is a DNS server?

That's a Domain Name Server. It is a software component which is part of Windows Server and becomes used for looking up IP addresses by domain names. For more information see DNS Server .
16. How can you improve performance for BizTalk?

	 + Scaling up =>add better CPU's, more RAM in the current servers
	 + Scaling out =#### add more servers, create Failover- and Load Balanced clusters, add MessageBoxes
	 + Increase resources available for hosts
	 + Locate problem integration and prevent possible build ups in the databases.
See also TechNet Wiki article: Recommendations for Installing, Sizing, Deploying, and Maintaining a BizTalk Server Solution.
17. What is meant by “parties”?

A party is an entity outside of BizTalk Server that interacts with an orchestration. In BizTalk Server, each organization with which you exchange messages is represented by a party. You can define how the party interacts by enlisting it in a role. For more information, see Managing Parties .
18. Which default adapters cannot run with 64 bit OS?

	 + FTP-adapter
	 + POP3-adapter
	 + SQL-adapter
See MSDN BizTalk Server 64-Bit Support (BizTalk 2010) or BizTalk Server 64-bit Support (BizTalk 2013).
19. Which default adapters can only run with a single Host Instance?

All the adapters which lack a locking system, like FTP, POP3, and MSMQ. For a high available BizTalk Group these adapters need to be clustered. For more informations see MSDN Considerations for Running Adapter Handlers within a Clustered Host .
20. What is TDDS?

TDDS stands for Tracking Data Decode Service. This service is responsible for moving tracking event data from the BizTalk Server MessageBox database to the BizTalk Server tracking database and BAM is BAM is used.
21. What are best practices for tracking in production?

Just use it when it's absolutely necessary! Turn off any non-default tracked artifacts as soon as possible! It's a pain for your overall performance! See Best Practices for Message and Instance Data Tracking and Best Practices for Tracking .
22. What is global tracking and what does it track when global tracking is on?

Global Tracking is the general Tracking switch. If it's turned off, nothing will be tracked. If it's turned on, by default it tracks instances, in and out events for all pipelines. All application containing orchestration exported from Visual Studio will by default have all orchestration event tracking turned on, it's recommended to turn this off in any production environment. See MSDN How to Turn Off Global Tracking (BizTalk Server 2010), How to Turn Off Global Tracking (BizTalk Server 2013) and for previous versions see question 40.
23. What is the difference between BizTalk 2009 and 2010?

Much better mapper tool, support SQL Server 2008 and SQL Server 2008 R2. Better administration console. VS 2010(!) is used for development. See also MSDN New Features in BizTalk Server 2010 . There have also been a lot of changes and all host settings have been transferred and moved into the administration console.
24. What is a Cumulative update?

One cumulative update package for Microsoft BizTalk Server and contains hotfixes for BizTalk Server, issues that were resolved after the release of a particular version of the BizTalk Server and includes all the component packages. Cumulative Update package take some minutes to install, and you'll need to restart the server after you apply the CU.

The cumulative update should be installed on all servers that run BizTalk components.
Important note: The cumulative update package updates only those components that are installed on the system. See List of Service Packs and Cumulative Updates available for BizTalk Server. In BizTalk 2013 the updates for BizTalk is pushed to regular updates, versions prior to this has to be downloaded and installed manually.
25. How many BizTalk versions are there?

Until now (August 2013), we've seen BizTalk 2000, BizTalk 2002, BizTalk 2004, BizTalk 2006, BizTalk 2006 R2, BizTalk 2009, BizTalk 2010 and BizTalk 2013. That makes 8 major versions! See BizTalk Versions
26. What is the BizTalk Adapter Pack?

The BizTalk Adapter Pack is a package which contains several adapters for LoB systems. adapters for SAP, Siebel and Oracle. See BizTalk Server Adapter Pack 2010.
27. What is the ESB toolkit?

The BizTalk ESB Toolkit provides architectural guidance, patterns, and a collection of BizTalk Server and .NET Framework components to simplify the development of an Enterprise Service Bus (ESB) on the Microsoft platform and to allow Microsoft customers to extend their own messaging and integration solutions. See BizTalk Server ESB:Survival Guide.
28. What is required to install the SharePoint adapter in BizTalk 2010?

BizTalk Server 2010 support the following SharePoint versions: SharePoint Services 2010, SharePoint Foundation 2010, WSS 3.0 with Service Pack 2 (SP2), and Microsoft Office SharePoint Server 2007 Service Pack 1 (SP1) (MOSS).
One of this components must be installed because is required for using WSS Adapter. See BizTalk Server integration with SharePoint Server using WSS adapter.
29. What is special about the BizTalk Backup job?

It is special, because this job represents the only correct way to make backups from BizTalk, the job also performs a transactional backup so a restore will happen without having invalid and out of sync databases. See also Aspects of backup BizTalk Server

30. Which SQL agent job came in BizTalk 2010?

A job that monitors certain aspects of BizTalk Server which are mainly related to Message and Instance reference counts. See which aspects the job monitors exactly Monitor BizTalk Server

31. Which tool was removed in BizTalk 2009?

In BizTalk 2009 the HAT (Health and Activity Tracker) has been removed. Its functionality, track and display information relating to live and historical message data, is now available from the Group Hub. See MSDN Using the Group Hub Page .
32. How does the BizTalk Administration Console cache applications?

The BizTalk Administration Console maintains a local cache and when the administration console is opened it caches the entire configuration in one go. The refresh interval can be configured, default is 60 seconds. You can change this value, see MSDN How to Adjust the Configuration Cache Refresh Interval and Troubleshooting BizTalk Server Administration .
33. How can you solve slow Administration Consoles?

When administration console is slow then you need to check a few things concerning SQL Server like size of BizTalk databases, connectivity with SQL Server, or set the Recovery Mode of all BizTalk databases from Full to Simple (not recommended in production, see MSDN Recovery Models and Transaction Log Management on implications of this setting, you may also want to check the certificate Revocation List, you can read more hereCommon Issues and Resolutions with the BizTalk Server Administration Console.
34. What should be included in a basic guideline?

A BizTalk guideline will give you the benefits of having the availability to improve stability, optimize the work flow for BizTalk and keep a track of information regarding your environment, and the way these things work at your company. This will make it easier for new people coming in working for or at your company to understand how BizTalk works at your company.
What the guidelines for your company should contain is all up to what you need. You need to keep information regarding routines, setup, configuration, backup routines etc. So all knowledge regarding the company structure for BizTalk is saved and stored whenever someone quits or for instance hiring a consultant. The guidelines can also provide values needed to improve the communication between developers and administrators. See also:BizTalk Administrator: Guidelines
35. What can you use the tracking database for?

This database stores health monitoring data tracked by the BizTalk Server tracking engine.
	 + It stores data of completed processes which comes from the MessageBox
	 + It stores data of suspended/terminated processes which comes from the MessageBox
	 + Can be used for report generation
	 + Can be used for monitoring
	 + Can be used for analysis
	 + Can be used for Orchestration debugging
36. What is a trusted / un-trusted host?

BizTalk Server enables hosts identified as authentication trusted to indicate that the sender of a message that the trusted host is queuing to the MessageBox database is an entity other than the trusted host itself. The primary purposes of authentication trust are to enable pipelines to resolve to a Product ID (PID) and pass that PID along to consuming services for use in authorization and outbound party resolution, and to enable the transmission of the sender Windows Security ID (SSID) along to consuming services for use in orchestration action authorization. See BizTalk Hosts .
37. What is MSMQ used for?

MSMQ stands for Microsoft Message Queue. It's a queuing mechanism which comes out-of-the-box with Windows Server. Be aware that MSMQ lacks a locking mechanism and therefore has to be accessed from a single Host Instance. Use a Failover cluster to make this Host Instance high available.
38. What is meant by dedicated hosts?

When a BizTalk Group has Dedicated Hosts, it has Hosts which are dedicated for i.e. Receiving, Sending and Processing messages and orchestrations. See TNWiki article BizTalk Server: Host Architecture.

39. Should the DTA Purge and Archive job be configured and running if you have global tracking turned off?

Yes, even if Global Tracking is turned off, you should keep the DTA Purge and Archive job configured and running. The reason is that for each Terminated Instance a row wll be written in the tracking database. These rows need to be cleaned up by the job. See DTA Purge & Archive Job when Global Tracking is disabled .
40. What has not been changed regarding hosts since BizTalk 2006?

[Requires an answer]
41. How do you turn off global tracking in BizTalk 2006 - 2006 R2?

In BizTalk Server 2006/2006 R2 the Global Tracking can be turned off through a manual action in BizTalk Management Database, see this blog post: Turn off tracking globally in BizTalk Server 2006 .
42. What is the main difference between BAM and DTA?

BAM (Business Activity Module) has a business driver, while DTA (Data Tracking Architecture ) is used for Tracking purposes. With BAM Users can define Views and Notifications based on certain (Business) events. These views can be used from a SharePoint portal. This portal is also the place where Notifications are created.
43. What is the use of taking a backup of the Master Secret Server Key?

The Enterprise Single Sign-On master secret is stored in an encrypted registry key on the master secret server in the production site. The master secret should be restored to the disaster recovery site as a normal part of disaster recovery preparations. See MSDN How to Restore the Master Secret Server and BizTalk Server 2010: Enterprise SSO Survival Guide. Note that is vital that this key backup properly and somewhere where it can be accessed in case it need to be used to restore SSO. If this key is lost or password to protect is unavailable then it will lead to reconfiguring the BizTalk Group!
44. What is the use of Enterprise Single Sign On?

Enterprise Single Sign-On (ESSO) is an important component of BizTalk Server. ESSO is responsible for securely storing critical information such as secure configuration properties for the BizTalk adapters. On each computer where BizTalk runtime is installed the ESSO is present. Typically ENTSSO is installed to: C:Program FilesCommon FilesEnterprise Single Sign-On. See BizTalk Server 2010: Enterprise SSO Survival Guide and MSDN Enterprise Single Sign-On .
45. What is BTSNTSVC.exe.config file?

This is the configuration file for BTSNTSVC.exe, which runs as a Windows Service and is a Host Instance, information regarding the configuration of the hosts. See MSDN BTSNTSvc.exe.config File .
46. What is difference between Dehydrated Orchestration and Suspended Orchestration?

Dehydration is the process of serializing the state of an orchestration into a SQL Server database. Rehydration is the reverse of this process: deserializing the last running state of an orchestration from the database. See MSDN Orchestration Dehydration and Rehydration . When a failure occurs within an orchestration and no error handling is implemented it will be suspended. See MSDN Orchestration Failures .
47. Importance of Strong Name and how it helps for administration?

A strong name ensures that each assembly name is unique. Each assembly in your BizTalk project requires a strong name in order to deploy successfully. See also How to Configure a Strong Name Assembly Key File .
48. What is the maximum size of message, BizTalk can process?

While BizTalk Server imposes no restriction on message size, practical limits and dependencies might require you to minimize the size of your messages because large messages require more processing resources. See MSDN Message Considerations (BizTalk 2010/2013). For earlier BizTalk versions like 2004, see MSDN BlogLarge messages in BizTalk 2004, what's the deal?
 .
49. Why BizTalk MessageBoxDB MaxDOP value should be 1?

DOP stands for Degree of Parallelism. BizTalk Server database queries are relatively small, and they execute quickly. Therefore, BizTalk Server database queries do not benefit from a Parallelism setting that specifies using more than one processor. Changing the Parallelism setting to specify using more than one processor may have an adverse effect on BizTalk Server database queries. See also The Parallelism setting for the instance of SQL Server when you configure BizTalk Server .
50. How many host can we have?

There is no rule about how many hosts you may have. However there are certain guidelines and its recommended to have hosts for the following
	 + Receive Host : Used for all in process receiving
	 + Processing Host : Used for all Orchestration
	 + Isolated Host: Used for all IIS receiving
	 + Send Host : Used for sending of messages
	 + Tracking Host : Used for moving data from MessageBox to Tracking database
There may be more then one for each of these jobs depending on the workload and resource usage including host settings etc.
51. Where can you locate configuration of your environment?

You can locate configuration information both on the BizTalk machines and the BizTalkMgmtDb.
This article is a Part 1 of the Interview Questions series.
Part 1: BizTalk: Questions for interview without answers
Part 2: BizTalk: Interview questions and principles
Part 3: WCF: Questions for studying and interview
Part 4: WCF: Questions for studying and interview: Discovery
Part 5: WCF: Questions for studying and interview: Routing Service
Part 6: BizTalk: Advanced Questions
Standards
BPEL4WS: Comparing of BizTalk 2004 and BPEL4WS
+ Which points is the BTS Orchestration different from BPEL4WS in?

+ Which objects in the BTS have different names from BPEL4WS?

+ Does the link object have a state?

+ What does it mean the "JoinCondition"?

+ What is the BizTalk analogue of the BPEL "Message Event" object?

+ What is the BizTalk analogue of the BPEL "Alarm Event" object?

WSDL 2.0
+ Which are names of the root tag and the upper level tags in WSDL 2.0?

+ Which children are nodes the "operation" and "endpoint"?

+ Can we use the third party schemas in the WSDL document?
 How?

Theory, Principles
Subscription/Publishing mode
+ What are two main types of subscriptions?
 What is the difference?

+ What is the Message Agent?
 It is the service for polishing/subscribing of the messages. (?
)
+ What is the Endpoint Manager?

+ What is the Message Type?

+ When a send port creates a subscription?

+ Do we use enlist/unenlist operations for subscription or for publisher services?

+ Which three artifacts we can enlist/unenlist?

+ Is the Binding implementation of the Subscription/Publishing model?
 If "No", what the model is it implementing?

+ Why some BizTalk artifacts can be Enlisted and Started and others can only be Enabled?

+ What kind of errors depends of those actions (Enlisted, Started, Enabled)?

Orchestrations
+ Can I receive one message with the same type from different Receive port to one Receive shape?

+ Can I receive the same message with the same type to several Receive shapes?

+ Can I send the same message to the different Send ports?

+ Can I send the different messages with the same type to several Send ports?

+ Where do Filters for SP and RP “locate“?

+ Can several Transform shapes be used inside one Construct shape?
 If can do the Source message "map" both of them to the Target message or only one of them?
 Which one?

+ Can Transform shape and Assign shape are both used inside one Construct shape?
 If can do the Source message "map" both of them to the Target message or only one of them?
 Which one?

+ Which properties of the operations on the Port shape are using and what purpose for?

+ How we can transform data between types: String, XmlDocument, message - inside Orchestration?

Transactions inside Orchestrations
+ Does Shape “Throw Exception” create an event or/and a Suspended Instance Service, if surrounding scope doesn’t handle this exception?

+ What the difference between Atomic and Long-Running transactions?

+ Can we add the Compensation block to the Atomic/Long-Running transaction scope?

+ Where can we use the Compensate shape?
 Inside the Compensate block or/and inside the Exception block or/and somewhere else?

+ Can we catch an exception in the Exception block of the transactional block, if it is thrown inside this transactional block?
 Can we catch an exception in the Compensation block of the transactional block, if it is thrown inside this transactional block?

+ What the difference between the Compensation block and the Exception block?

+ What does the "Default" compensation mean?

+ How many Compensation blocks and Exception blocks can be added to one Long-Running transaction scope?

+ How the BizTalk persists the state across/inside the transactional scope?

+ Can we use the serializable .NET classes inside Atomic transactions?
 Inside Long-Running transactions?
 What about unserializable classes?
 How do we made the .NET class serializable?

+ Can we add the Exception block to the Atomic/Long-Running transaction scope?

Maps
+ Can we see the name of method or class or assembly of the External Script functoids in the Property window?

+ Can we pass the value of the string/Boolean/int typed node to the Script functoid if the method of this functoid has input parameters of another type?
 If can where the transformations doing?

+ Which is right for the input Boolean parameter of the method of Script functoid: "TRUE", "True" or "true"?

+ Which value we get as the output Boolean parameter of the method of Script functoid: "TRUE", "True" or "true"?

+ Can we use 1/0 as the input Boolean parameter of the method of Script functoid?

+ Can we get the value from the Logical functoid to the Destination XML document?

+ Which value we can use on place of the Boolean input parameter of the functoid: "True", "TRUE" or "true"?

+ When we “Test map“ with “Generate instance“ option how much records would be generate for record with “Min Occurs“ equal 0 and “Max Occurs“ equal “Unbounded“?

+ When we “Test map“ with “Generate instance“ option how much records would be generate for record with “Min Occurs“ equal 1 and “Max Occurs“ equal “Unbounded“?

+ How we can get the name of node from Source Xml document to mapping?

+ How we can get the name of node from Target Xml document to mapping?

+ How we can eliminate mapping of the Empty source node?
 (An empty source node should NOT create the empty target node)
+ How we can enforce mapping of the Empty target node?
 (An absent source node should create the empty target node)
+ Can we choose between creating two kind of the Empty target nodes in mapping, and (with two tags and one tag)?

+ Can we choose between creating the Empty target node and eliminating the Empty target node in mapping?

+ Is there any difference in processing “the Empty node” and “no node” cases in mapping?

+ We produce a target node with "Value Mappong" functoid. This node has properties "Max/Min Occurs" = default (1) and "Default Value" = "0". Which value have we got if first parameter of the "Value Mappong" functoid is equal "false"?

("0" / Empty string / 0 (integer) / null (node is not created))
+ Where you prefer to use Xslt inside the maps?
 Why?

+ How to make the map more readable?

+ Can we create the map without functoids at all?

Ports, Adapters
+ Where are the maps assigned to the Receive Locations and Send Ports?

+ If we delete a Send port from the Send Port Group do we delete the Send Port itself?

+ If we delete a Receive Location from the Receive Port do we delete the Receive Location itself?

+ Do Send port and Receive Port have the same object structure?
 Tell about how the properties assigned to the objects.
+ Do the Service Window for Send and Receive ports have the Properties "Start Date" and "Stop Date"?

+ Are parameters of the Service Window of Send ports and Receive ports saved in the binding file?

+ Which advantages/disadvantages are creating ports from the Orchestration by options “Specify now” or “Specify later”?

+ Can we make file in the FILE Receive Location undeleted?
 What was going on in this case?

+ Why Receive Port can get a collection of Maps on it but Send Port Group can't get Maps (Send Port can)?

+ Why Receive Port can get a collection of Maps but a Receive Location cannot?

+ Can we create a collection of Maps with different Target Schemas on a Receive Port?

+ Why Receive Port and Receive Location can not get a Filter on it but Send Port can get a Filter?

+ Are the Send Port and Send Shape of the Orchestration (both Subscribers / both Publishers / first is the Subscriber and second is the Publisher / first is the Publisher and second is the Subscriber / none of this)
+ Does the Send Port ( 1).send message / 2).receive message / 3).publish message / 4).subscribe to the message / 1 + 2 + 4 / 1 + 2 + 3 / none of this)
+ Does the Receive Location ( 1).send message / 2).receive message / 3).publish message / 4).subscribe to the message / 1 + 2 + 4 / 1 + 2 + 3 / none of this)
SQL Adapter
+ What the difference between one-way and two-way SQL Send ports?

+ Does the one-way SQL Send port have the Response part?

+ Can we manually edit the "URI" parameter of SQL Send port and or Receive Location?

+ Can we use the same URI for several SQL Receive Locations?
 Can we use the same URI for several SQL Send ports?

+ Are the SQL Adapter Handler properties the default values for all Ports, or something else?

+ Which advantages/disadvantages has working with SQL data base through SQL Send and Receive ports vs. working from Orchestration through .NET classes?

+ What is the purpose of generating Multi-part messages by “Add Adapter” Wizard?

+ We have generated artifacts by “Add Adapter“ Wizard for SQL Port. What we should do to move them to the different Orchestration?
 What we should do to move them to the different Orchestration in different Project?

+ How we can add adapter to the BizTalk?
 Is it possible by using “Add Adapter” Wizard?

Security
+ How we can protect data from tracking using schema parameters?

+ Is the isSensetive attribute worked for promoted properties?

+ Who own the private part of the key certificate to encrypt message?
 (Sender/Receiver/SSO service)
+ Who own the private part of the key certificate to sign message?
 (Sender/Receiver/SSO service)
+ Is the Other People certificate store used on (Per Local Computer/Per Local User/Per Domain User) basis?

+ Which certificate store is used for store the public part of the key certificates?

(Personal certificates/Trusted publishers/Untrusted certificates/Other people)
+ Which certificate store is used for store the private part of the key certificates?

(Personal certificates/Trusted publishers/Untrusted certificates/Other people)
+ Which account do we have to log into to import the decryption certificates to the personal certificate store?

(Local user account/Host service account/Administration account/SSO Administration account)
+ If we have several personal certificates for sign the outbound messages which one will be used?

(Specified in the BizTalk Administration Console/Specified in the Certificate service Management Console/Specified in the Configure your server Wizard/Specified in the Local Security Policy Console)
+ There are steps to configure BizTalk for party resolution. Which one is wrong?

	 + A. To install certificate to the certificate store.
	 + B. To receive certificate from partner.
	 + C. To send certificate to partner.
	 + D. To create a party to represent a partner.
	 + E. To create a pipeline for party resolution.
	 + F. To configure the receive location.
	 + (A/B/C/D/E/F)
Tracking, HAT
+ What can be the cause of Suspended messages?

+ How we can see the body of the Suspended message?

+ How we can see the context of the Suspended message?

+ You deploy a new version of MyPolisy and want to get the tracking data from it. What you should do?
 (Choose the new version of MyPilicy in Configuration/Policies window of HAT?
 Nothing if you also configured HAT to get tracking information from previous version of MyPolicy.)
+ How to see in HAT the tracking data of your policy?
 (Choose from the “Queries” menu the “Most receive Policy“ command / Choose from the “Queries” menu the “Most receive Fired actions“ command / In “Message Flow” window for the Service Instance which calling your policy you should see the text “Follow this link to view the Policy execution details for this Orchestration Instance“ and click this text)
+ HAT: Menu Operations: Is here data from (MessageBox data base / Tracking data base / both of them / BizTalkMsgBoxDb.Tracking* tables)?

+ HAT: Menu Queries: Is here data from (MessageBox data base / Tracking data base / both of them / BizTalkMsgBoxDb.Tracking* tables)?

+ HAT: Menu Operations: Column "Service Class": Its value can be "Orchestration" and "Messaging". Is the "Messaging" the (Adapter Instance service / Pipeline Instance service / Port service / Port Instance service / undefined)
+ HAT: If the message is Suspended we can frequently see that there are more then one Messages Suspended and related to first Suspended, like a chain of them. Could you describe the situation?

Rule sets, Policies
+ You use in MyPolicy some facts from MyXmlDoc schema. When you are choosing MyPolicy in the Call Rules shape you can not see and choose the parameters of MyPolicy. Why?
 (You have only one message variable with MyXmlDoc type and it chosen automaticaly / You did not change manualy property the “Document Type“ for facts of the MyXmlDoc schema / You use the wrong version of MyPolicy in Orchestration / You use the wrong version of vocabulary for MyPolicy)
+ You use MySchema in the MySolution.MyProgect assembly and use in policy MyFact that is NodeA under RootNode of the MySchema. What the value should be property the “Document Type“ for this fact?
 (MySchema / MySolution.MyProgect / MySolution.MyProgect.MySchema / NodeA / RootNode.NodeA / MySchema.RootNode.NodeA / MySolution.MyProgect.MySchema.RootNode.NodeA)
+ You deployed 1.1 version of MyPolicy, then chose MyPolicy in CallRules shape of MyOrch, then you deployed the assembly with MyOrch, and then you deployed 1.2 version of MyPolicy. Which version of the MyPolicy is in use?
 (1.2, 1.1, you should change the version of MyPolicy in CallRules shape)
+ You use a Policy in an Orchestration. Action in your Rule has changed a value of node in Xml message. How you can get this new value in Orchestration?

(I get it in the Expression shape only if it is promoted. / I get it in the Expression shape anyway by xpath(). / I have to use a variable to pass this value to the Orchestration.)
+ You use in your Vocabulary and Policy class PolicyHelper. You have changed the name of this class to the PolicyOneHelper. What will be going on in Composer?

(Because the assembly name and namespace are not changed, Policy and Vocabulary will automatically change name. / You have to manually change the name in Composer. / You have to manually choose class with new name in your definitions/rules for Vocabulary/Policy. / You could not open those Vocabulary and Policy and will get an error.)
+ You use a Policy in an Orchestration. You start to use new class in your Policy. You have deployed new version of this Policy.
Will your Orchestration work without any error?
 (Yes/No)
Will your Policy work in the Orchestration well?
 (Yes/No)
Do you need to manually change an Orchestration?
 (Yes/No)
Have you got an error if you try to rebuild Orchestration without this change?
 (Yes/No)
+ How can we track executing of the Rules?

(HAT/Queries/Policies; / load Add-On to HAT then HAT/Queries/Policies; / HAT/choose one of the Service Instance lists ->Right click on one Service Instance/choose Message Flow/choose link "...to view the Policy...")
+ If we open HAT, a window "Policy Execution Details" and go to the one of the windows with the rule execution information (like "Fact Activity") how we can go back and forward between those information windows?

(File / Navigate back/forward; Alt- -#### 2013 BTS: BizTalk Adm.Console, PerfMon
BAM:
= Describe creating the tracking profiles, activities, views.

Programming skills:
* "bear route" problem or similar logical problem :)
* bubble sort algorithm
* test-driven programming
* .NET languages
* script languages, utils
* SQL: database normalization, programming

Architecture skills:
* Architect a standard applications:
= workflow with several messages
- a correlation
- convoys: parallel; sequential unified; sequential non unified
= instance vs. active subscriptions
= FIFO, ordered delivery
= BizTalk to/from SQL app:
- send data to SQL
- receive data from SQL
- query SQL data
- where to validate data?

= maps and ports
= BizTalk to/from WS/HTTP apps
- SOAP, WCF ports, artifacts, wizards
* error handling in the BizTalk applications
* ESB and BizTal

= What additional tools has contender used for the BizTalk/integration application and dig up those areas.

There is a good article by Richard Seroter [BizTalk] Interview Advice (http://seroter.wordpress.com/2007/07/27/biztalk-interview-advice/)
This article is a Part 3 of the Interview Questions series.
Additions (2008-06-18):

Debugging:
+ What tools are used for the debugging WCF?

+ Is it possible to log the messages on the service side?
 On the client side?
 How to switch on the logging?

+ What is a difference between the service messages and transport messages?

+ What is a difference between the SoapUi utility and the VS2008 test functionality used for the Web-service testing?

+ Describe how to use the LoadGen to test WS. What kind of tests?

________________________________________
Configuration files:
+ Enumerate the high level elements of the section.
+ What is the name attribute of the element?

+ What is the contract attribute of the element?

+ What is the difference in the attributes the binging and the bindingConfiguration of the element?

+ What is the difference in the attributes the binging and the bindingName of the element?

+ Are the addresses, the bindings, the contracts unique between services?

+ How are dependent the app.config and the machine.config files?

+ Enumerate the high level of the and element.
Service contracts:
+ Enumerate three message exchange patterns in the WCF model.
+ If the service operation returns void, what is the message exchange pattern?
 Is the client waiting the operation to be completed in this case?

+ What is the difference between the request-response pattern and the duplex pattern?

+ Is the server set up a client address or the client sets it up in the duplex communication ?
 Server uses this address to sent the data back to the client.
Fault contracts:
+ In what order do we have to catch the exceptions: TimoutException, FaultException, FaultException, CommunicationException?

+ You are developing a WS. Do you have to include the error(s)/success nodes into the response or have to use a Fault message to handle the WS errors?
 What is the difference in these approuches?

WCF versions:
+ In what version of the .NET was the WCF introduced?

+ What was the main functionality set for the first version of the WCF?

+ What were the new WCF things in the next versions of the .NET?

Sessions, Instancing, and Concurrency:
+ Why do we need the sessions?

+ Where session stores the session information?
 What is the general store for the WCF session?

+ What is it a correlation?
 What parameters are mandatory for the correlation?

+ Who does initiate the WCF session, service or a client?

+ What is the order of the delivered messages processed in during the session?

+ How can we create a singleton service?

+ Does the SessionMode.NotAllowed increase the performance?

+ What is it the Terminating and Initiating of the OperationContract?
 Could be the OperationContract Terminating and Initiating at the same time?

+ How does a client start a session?

Transports:
+ How to enable streaming?

+ What types of the operation contract parameters can be streamed?

+ Do we have to change the maxReceivedMessageSize parameter to use streaming?

+ What types of the quota have the WCF transports?

+ What is it the Teredo?
 How can we use it?

+ What is it the Net.TCP Port Sharing?
 How can we use it?

Queues and Reliable Sessions:
+ What types of reliable messaging are implemented in the WCF?

+ What is it the Reliable session?

+ Is the Reliable session asynchronous?

+ Is the Reliable session tied to the transport session?

+ Can the Reliable session be established with the one-way, or the request-reply, or with the duplex, or with all those exchange message patterns?

+ Do the system-provided bindings have the support for the Reliable session and what the binding options are enabled by default?

+ Reliable sessions in Windows Communication Foundation (WCF) use a transfer window. What is it the Transfer window?
 What does it means for the sender, for the receiver?
 How is it depend of the latency?

+ What is it the Transmission queue and the Target queue?
 What is the difference?

+ What is it the Dead-letter queue and the Poison queue?
 What is the difference?

+ Could the two-way service operations be used with queued binding?

+ Could the ExactlyOnce property of the netMsmqBinding be true if the queue is not transactional?

+ When is the MsmqIntegrationBinding or the NetMsmqBinding used?

+ Is there an error in the Msmq address the "net.msm1. //MyHost/private$/MyQueue"?

+ Can we use the public queues without the Windows domain?
 If cannot then why?

+ Is the MsmqIntegrationBinding used the msmq.formatname scheme or the net.msmq scheme?

Hosting:
+ What hosting functionality is unique for the Vista OS?

+ Do we have to use the relative addresses when hosting in the IIS or the absolute addresses?
 Why?

+ Could the IIS-hosted WCF service make use of HTTP transport security if the IIS virtual derectory that contains the service does not support it?

Behavior:
+ What kind of behaviors are possible in WCF?

+ Why the Endpoint behavior cannot be used as an attribute?

+ Why the Contract and the Operation behavior cannot be used in the configuration files?

This article is a Part 4 of the Interview Questions series.
Q&A: WCF, Discovery
+ When the WS-Discovery standard gets approval first time?

+ Is the WS-Discovery using the XML format for messages?

+ Is the WS-Discovery using the SOAP format for messages?

+ What are the versions of the WS_Discovery protocol?

+ What version is the default version?

+ What is a difference between the Add-hoc and Managed modes?
 What are the Pro and Cons?

+ Describe the message exchange sequences of the Discovery protocol.
+ What are the message exchange sequences in the Add-hoc and Managed modes?

+ Can the Add-hoc and Managed modes be switched dynamically?

+ What messages are multicast and what are unicast?

+ What is the Discovery Proxy service?

+ It there a default Discovery Proxy service?

+ What is the difference between the Probe and Resolve requests?

+ What are the response messages for the Probe and Resolve requests?

+ What are the response messages for the Probe and Resolve requests if there is no match?

+ Who sends the announcement message, service or client?

+ What announcement messages are used?

+ Is announcement using a Special endpoint?

+ Is announcement optional or mandatory?

+ How to make a Web-hosted service discoverable?
 What two options do we have?
 How AppFabric or Discovery Proxy service is used to help with it?

+ What is a FindCriteria class?
 What are the Search criteria?

+ How long a client is waiting the results from the discovery request?

+ What happens if a discovery request didn’t get you any service endpoint?

+ Can we use different versions together on a single service host?

+ What endpoints are used for the Discovery?

+ What is a difference between the DiscoveryEndpoint and the DynamicEndpoint?
 Do we have to use a DynamicEndpoint with a DiscoveryClient?

+ What Discovery endpoints are the system endpoints?

+ How to make a custom endpoint discoverable?

+ Why the UPD protocol is used for discovery?
 What pros and cons?

+ How to use the Discovery Client Channel?
 What are alternatives?

+ What are the pros and cons using the Discovery Client Channel?

+ How to create a DiscoveryEndpoint on demand?

+ Can you compare the WS-Discovery and the UDDI?

This article is a Part 5 of the Interview Questions series.
WCF, Routing Service
Q&A
+ What are the features of the Routing Service (RS): Protocol bridging; Message transformation; Content-based routing; Application pools; Dynamic configuration; SOAP processing; Service hosting; Error handling; Backup endpoints?

+ Which routing scenarios can RS implement: Service aggregation; Interface recomposition; Service versioning; Service chain; Priority routing?

+ Is it possible to modify the routing configuration at run time?

+ What is the RS doing if there is no match for a message routing?

+ Can we route to the mix of the one-way and two-way destination endpoints using a single service endpoint?

+ Do we have to create the implementation of the RS as a .NET class or an .svc file with “Service="System.ServiceModel.Routing.RoutingService, …” plus a configuration file is enough?

+ What is it a SOAP processing?
 How it works?

+ Can it convert messages between Soap 1.1/Soap 1.2/Soap 2.0 and/or WS-Addressing August 2004/WS-Addressing 1.0?

+ What is it a Backup endpoint?

+ What is the maximum number of the Backup endpoints?

+ What is it a Protocol bridging?

+ What is it a Content-based routing?

+ How the Priority routing is working?

+ How we can host the RS?

+ Are there limits on using streaming for the RS?
 Where we have to buffer the messages?

+ How we can expose mex endpoints of the original services through the RS?

+ Can we use the RS as a load balancer?

This article is a Part 6 of the Interview Questions series.
Advanced level
+ The error in BizTalk usually creates a suspended message. But routing error creates two messages. Why so?
 How we could utilize this feature?

+ Send ports have an “Ordered delivery” option. How it works for a File adapter, if the File protocol does not have a notion of file order?

+ Send ports have an “Ordered delivery” option but Receive ports do not have it. Why so?

+ You set up an “Ordered delivery” option in a Send Port. What is special about a Service Instance of this Port?

+ How to force an Orchestration do the ordered delivery?
 Is there a special “Ordered delivery” option in an Orchestration?
 If it is not, why?

+ Send ports have the “Priority” options, but Receive ports and Receive Locations do not have them. Why so?

+ How does the Priority feature of the Send Port work?

+ Why the Priority option can be set up only for the Send Port?

+ Send ports have the “Retry” options, but Receive ports and Receive Locations do not have them. Why so?

+ How does the Retry feature of the Send Port work?
 In what scenarios this feature is helpful, in
+ Send ports have a “Backup Transport” but Receive ports do not have it. Why so?

+ Send ports have a “Filter” but Receive ports do not have it. Why so?

+ Send ports have the “Maps” and “Transport”; Receive ports have “Maps” but “Transport” is associated with Receive Locations. Why so?

+ What is the difference between “Send Port Group – Send Port” relation and “Receive Port – Receive Location” relation?

+ Receive Locations have the Schedule parameters for date and time but Send Ports have the Schedule parameters only time. Why so?

+ Can we create two Send Ports with the same URL?
 Can we create two Receive Locations with the same URL?
 Why so?

+ Filter expression for the Send Port is defined at run-time, but Filter expression for the Orchestrations is defined only at design-time. Why so?

+ We created a custom pipeline component. Do we have to place it into the “Pipeline Component” or install it to GAC or both?

+ How does an Orchestration make sure the message was sent successfully by one-way Send port?
 How does it changed for a two-way Send port?

+ What is it the “CodeList Database” property of the Schema?
 How to use it?

+ What is the “Property Schema Base” property of the Property schema element?
 It has the values: MessageDataProperyBase, MessageContextPropertyBase, and PartContextPropertyBase. What is the difference between using MessageDataProperyBase and MessageContextPropertyBase?

+ We bind an Orchestration with a Send Port. What does it do regards of the subscription?

+ We bind an Orchestration with a Receive Port. What does it do regards of the subscription?

+ How do Filters of the Send Ports and Send Port Groups work together?
 Say, a Send Port belongs to a Send Port Group. If this Send Port and this Send Port Group have the same Filter expression, does it create two subscriptions and, as a result, two messages are sent to the Send Port?

+ Why do we need a special Property schema for Promoted properties?
 What is the purpose of this schema?
 Distinguished properties do not use this kind of schema. Why so?

+ Properties of some BizTalk artifacts have a Tracking option. Right-click menu of some BizTalk artifacts have the “Tracking…” command. Why there is such a difference between artifacts?
 Why Maps do not have any Tracking options?
 Why Schemas have only Tracking property?
 Why Send Port Groups do not have any Tracking options?
 Why Receive Locations do not have any Tracking options?
 Why BizTalk Applications do not have any Tracking options?

+ When a BizTalk Assembly is deployed, is it stored in the BizTalk database or is it just referenced in the BizTalk database?

+ Why a BizTalk Assembly must be installed into GAC?
 Why deploying it to BizTalk database is not enough?

+ Can you describe at least three scenarios where smart Orchestration Engine finds the errors in the messages patterns at design time (while build a BizTalk project)?

+ A Host has an "Authentication Trusted" option. What does it mean?
 What implication it has to the message processing?
 How do we have to use it / don't use?

+ Could we create an XLANGMessage in the C#/VB code?
 Please, provide code.
+ We can use an XmlDocument class as a Message type for receiving the untyped Xml messages in Orchestration. What .NET classes do we have to use for receiving the untyped text or binary messages in Orchestration. Why so?

+ Is the Publish-Subscribe BizTalk Engine API well defined?
 Where?
 If not, why so?

+ Does the BizTalk use the strategy “First received, first processed” or “First received, last processed” of “First received, first processed, first sent” of something else?
 Why so?

Describe scenarios, when this strategy works better, and scenarios, when this strategy works badly.
+ Are Orchestration Instances processed in order?
 Why so?
 Describe scenarios.
+ Is it possible to force the Hydration / Dehydration of the Orchestration instances, Messaging instances?
 How to do this?
 Why do this?

+ In what scenarios will we use the Compensations in Orchestrations?
 Why so?

+ The Atomic scopes in Orchestrations have a Retry feature. How does it work?
 Describe scenarios when it is used.
+ What serializer is used inside the BizTalk, the XmlSerializer or the DataContractSerializer?
 What implication has it for the real life scenarios?

+ What transform engine is the BizTalk using, an XslTransform or an XslCompiledTransform?
 What implication has it for the real life scenarios?

+ The BizTalk Business Rule Engine uses a Rete engine. In what scenarios this Rete engine is the more efficient / less efficient?

+ Let’s classify the applications as Front-end, Middle-level and Back-end. Where are the best places to use BizTalk?
 Please, provide scenarios. What are the most important features we have to take in account?

+ What BizTalk features are the differentiators, when we compare the BizTalk Server with other alternatives?
 What are those alternatives?

+ What is a Heartbeat in the BizTalk?
 Why is it implemented?
 Can we change the heartbeat interval?
 How does this interval influence the processes in the MessageBox?

+ What is the difference, if any, between the ESB and the Broker conceptions?

+ How to set up a custom name for a dynamic send port?

+ What kind of the dynamic ports are existed?
 Are there dynamic send ports?
 Are there dynamic receive ports?
 Why is it so?

What is BizTalk Server?

Biztalk is a messaging based integration tool. It consists of several tools like Business Processes (Orchestrations), Business Activity Monitoring (BAM), HAT (Health and Activity Tracking), Rules Engines, BizTalk Server Administrative Console etc.
BizTalk Server 2006 R2 builds upon the Business Process Management and SOA/ESB capabilities and address core challenges found in key vertical industries such as manufacturing and retail. Native capabilities of BTS R2 include support for Electronic Data Interchange (EDI) and AS2 ,Windows Workflow Foundation, WCF as well as RFID.

BizTalk server 2006 R2 application can be created using Visual Studio 2005 provided BizTalk Server SDK is installed into the system. A standard BizTalk Server application consists of Schema, Mapping, and Orchestrations. The heart of the BizTalk Server application is schema that is used to define the message format of source and destination data.
BizTalk Server has capability to talk with any kind of legacy system as it only understand the plain text data (in the form of xml), in order to talk with different systems it has several inbuilt adapter like SQL Adapter, MSMQ Adapter, SMTP Adapter, File Adapter, SOAP Adapter etc.
What is MessageType in BizTalk Server?

BizTalk sets a message context property called BTS.MessageType. This is a concatenation of the document namespace and Root Node Name in other words Message Type is a BizTalk System property that is promoted inside a Pipeline. It is made up of Document Name Space and Root Node Name.
What is the default mapping for Auto Mapping?

The default mapping for Auto Mapping is is mapping by structure. This can be changed to by node name in the map properties.
What is Biztalk Orchestrations Dehydration and Rehydration?

Dehydration:
When an orchestration has been idle for a while, the orchestration engine will save the state information of the instance and free up memory resources.
Rehydration:
When a message is received, or else when a timeout has expired, the orchestration engine can be automatically triggered to rehydrate the instance – it is at this point that the orchestration engine loads the saved instance of the orchestration into memory, restores the state, and runs its from the point it left off.
List out some Artifacts of BizTalk Server?

#. HAT
#. BAM
#. Adapter
#. Pipeline
#. Orchestrations
#. Role Links
#.Send Ports and Send Port Groups
#.Receive Ports
#.Receive Locations
#.Policies
#.Schemas
#.Maps
#.Resources
#.BAS Artifacts (Business Activity Services)

What is the difference between a Document Schema and a Property Schema?

A document schema is used to define a message. It is a definition on an Xml message with optional extensions for flat files, EDI file, etc that enable the parsers to convert the native format into Xml.
A property schema is used to define message context properties. These can be of type MessageDataPropertyBase (the property value is promoted or demoted from/to the message itself) or MessageContextPropertyBase(property value only exists within the message context and can be set by adapters, pipelines or within orchestrations).
If you wish to promote a field from a message into the message context then you need to define a document schema and property schema. In the document schema you promote the required field using the property schema to define the property type that will be used in the message context.
What is Correlation in context of BizTalk Server?

An Orchestration can have more than one instance running simultaneously. Even though each of those multiple instances perform the same action, it does it on different data contained within a message.
Correlation is a process of associating an incoming message with the appropriate instance of an orchestration.
For Example: If your orchestration issues a purchase order, receives an invoice, and sends a payment, the developer must make certain that the invoice message is received by the orchestration instance which corresponds to the orchestration that sent the Purchase Order. Without correlation, it would be possible to send out an invoice for thousands of items even though the purchase order is for one. And each correlation is based on a set of properties known as correlation types.
#### What is the difference between Distinguished field and Promoted Property?

A: Promoted properties can be accessed in Orchestrations, ports, pipelines, schemas.
They Use server resources.
Distinguished fields are light weight and can be accessed only in Orchestrations.
What is the latest version of BizTalk Server?

The latest version of BizTalk is BizTalk Server 2009 and IDE to develop application is Visual Studio 2008 SP1.
Top New Features
BizTalk Server 2009 introduces enhancements and new featured in four main areas:

Updated Platform Support
Support for Visual Studio 2008 SP1
Support for .NET Framework 3.5 SP1
Support for Windows Server 2008
Virtualization support with Hyper-V
Support for SQL Server 2008
Developer & Team Productivity
New Application Lifecycle Management (ALM) experience - with Support for TFS - integrated source control, bug tracking, unit testing, MSBuild automation
Enhanced Developer Productivity with Visual Studio project system updates & Map Debugging
SOA and Web Services
ESB Guidance 2.0
New UDDI v3 Web Services Registry
New and enhanced LOB adapters (Oracle eBusiness Suite, SQL Server)
Enhanced host systems integration (WebSphere MQ, CICS, IMS)
Enhanced BAM support
Business to Business Integration
New Mobile RFID Platform
New RFID device management and industry standards support
Enhanced Support for EDI and AS2 Protocols and Drummond certification
Updated SWIFT Support and SWIFTReady Financial EAI Gold certification
What is the difference between a "Message Assignment" shape and an "Expression" shape?

A "Message Assignment" shape is used to create a new message and assign values to it.
A Expression shape is used to assign values to variables and also write 'if' conditions.

QuestionsAnswersViewsCompanyeMail

Is there any possibility in the biztalk FIFO(first-in-first-out) without use the orchestration?
 how to implement explain?

IBM, HCL,
199
________________________________________
what is the use of schema in biztalk and why we use schema?

IBM,
126
________________________________________
In orchestration dynamic send port generally we have to give destination path details i.e provided by client, but my question is how to get that particular address from where and where is it stored?

Cognizant,
165
________________________________________
In the dynamic send port actually we have to give the require destination details i.e, provided by client, but my question is how to get that particular address from where and where it is stored in biztalk?

107
________________________________________
How does the orchestration gets the message from message box?

1907
________________________________________
who is best faculty for BizTalk in hyderbad
32107
________________________________________
How can we process EDI file with out EDI pipeline.
Cap Gemini,
15566
________________________________________
who is best faculty for BizTalk in Bangalore
32388
________________________________________
can we promote property promotions through Orchestration?

Accenture,
45952
________________________________________
how to handle the error in soap
KPIT,
1044
________________________________________
i have one applition in biztalk, how to run anohther server
IBM,
946
________________________________________
If we are using single send port in two different host instances then either two copies of message will send or single copy will send to subscribers?

Sonata,
23540
________________________________________
When we are promote the fields as quick promote then they are stored in property schema,
when we promote as distinguished fields then where the fields stored?

Mind Tree,
34293
________________________________________
Is there possible to make atomic transaction as two way communication ?

Accenture,
14191
________________________________________
How many ways to restart the host instance in biztalk?

There are 4 ways to restart host instance:

+ VS 2008-->Select biztalk project-->properties-->in deployment pane-->select host restart ti true
+ go to run cmd-->type services-->select our host instance's SSO and click on restart
+ go to Biztalk admin console and select host instance and right click -->restart
+ Go to cmd prompt and type the command for host instance > restart	

### Why messages are immutable inside Biztalk?
### You have two schemas that need to be represented with the same root node and same namespace or different namespace, is it possible?
### In How many ways Orchestrations provide Subscription information to Message Box?
### how many Biztalk Components are there?


I have a receive port and send port whose message types are different.When I receive a message in my receive port,my process starts.I will construct my out message and give this to my send port.I am configuring a send port group to the logical send port.TO the send port group I have added many send ports with filters.The message in the send ports are not getting filtered based on my filters. Help will be highly appreciated. Thanks in advance
23492
________________________________________
What are convoys
KPIT,
24991
________________________________________
in which case you have to use updategram and stored procedure?

66929
________________________________________
define mapping,orchestration ,schema,adapters.pipelines,BRE,HAT,BAM ?

23939
________________________________________
what is custom pipeline and the use of custom pipeline ?
 why and how we use custom pipeline?

23781
________________________________________
Can we get messages to Orchestration without using schema?

78201
________________________________________
How to version your schema?

45719
QuestionsAnswersViewsCompanyeMail

What is Message routing and Content routing?

39896
________________________________________
What are Host and Host Instance?
 Did you deploy BizTalk more than one machine?

414770
________________________________________
How to transfer files without using Orchestration?

67505
________________________________________
In BizTalk development where and how you have to use custom developed .NET components?

KPIT, Blue Star,
45816
________________________________________
How and why you have to use Active Directory in BizTalk development?

24238
________________________________________
How to create dynamic ports?

ESH,
48400
________________________________________
Source schema has nodes First Name, Last Name and destination schema has node Name. How we can get data at destination so that we can have two instance of Name (without using orchestration).
45027
________________________________________
How to put data using SQL Adapter?

14712
________________________________________
what is the difference between promoted and distinguished property?

ABC,
510460
► Define BizTalk?

► components of Biztalk Server architecture?

► What is direct binding in BizTalk Server?

► What is distinguished field in BizTalk Server?

► Tell me how to transfer files without using Orchestration?

► What is BizTalk business process configuration?

► What is trading partner management in BizTalk?

► Explain the difference between BizTalk Server and Web Services?

► Explain the difference between routing and Content routing?

► Define content-based routing?

► Define the BizTalk Server convoy and correlation sets?

► How rules engine is provided in BizTalk Server?

► list the Persistence Points?

► Described persistence points?

► Define BizTalk Server rules engine?

► What is Promoted property in BizTalk Server?

► Described the purpose of BAM in BizTalk Server?

► What is BAM in BizTalk Server?

► How to use the message types?

► How to change the message type?

► What is message type (i.e. BTS.MessageType) in BizTalk Server?

► What BizTalk enables for companies?

► On what BizTalk Server 2000 is based?

► What BizTalk provides?

► Does BizTalk framework is an open framework?

► WHta is BizTalk framework?

► What is the difference between a "Message Assignment" shape and an "Expression" shape?

► What is the latest version of BizTalk Server?

► What is the difference between Distinguished field and Promoted Property?

► What is Correlation in context of BizTalk Server?

► What is the difference between a Document Schema and a Property Schema?

► List out some Artifacts of BizTalk Server?

► What is Biztalk Orchestrations Dehydration and Rehydration?

► What is the default mapping for Auto Mapping?

► What is MessageType in BizTalk Server?

► What is BizTalk Server?

BizTalk 2004/2006
This article lists down the BizTalk questions that every developer must know...
Introduction
These are the list of interview questions which every BizTalk 2004/2006 developer needs to know and answer
General
1. Does BizTalk 2004/2006 support Synchronous communication?

BizTalk is essentially Asynchronous. It can exhibit some synchronous behavior, if an Orchestration is converted into a web service.
2. Enumerate the new functoids added BizTalk 2006?

Please refer to this article New functoids in BizTalk 2006
Schemas
1. What is the difference between a Document Schema and a Property Schema?

A document schema is like any regular schema, whereas a Property schema consists of only child elements under a root node.
2. Can an Envelope schema consist of more than one schema type?

Yes. Technically it is possible.
Messaging
1. Can a flat file message be processing without a pipeline?

A Pipeline's job is to convert any external format into XML, be it a flat file or EDI or anything else.
2. Can multiple messages be processed or batched without an envelope schema?

It is possible to process multiple messages, without an envelope.
3. What is property promotion, why is it required?

When a property is Promoted, it is exposed to the orchestration/send port filters etc.
4. In which scenarios would use a "promoted property" vs "distinguished fields"?

The rule here is, if you dont want the schema element to appear in send port filters/debugging information then make it a distinguished field.
5. In Biztalk, what does a message type consist of?

A message type consists of the TargetNamespace#RootElement name.
6. What are un-typed messages, how does one create them?

A message created in BizTalk Orchestration is bound to a schema, this is a typed message. In un-typed messages, the message is bound to System.Xml.XmlDocument instead of a schema.
7. What is the difference between static, dynamic and direct binding?

Refer to Binding models in BizTalk
8. How does one enable subscriptions in BizTalk?

A filter on the Send Port is the first step to enable subscriptions in BizTalk.
Orchestrations
1. How do you prevent occuring of zombies in a Parallel Convoy?

Refer to the article known as "Convoy Deep Drive" on MSDN
2. What is the difference between a delay shape vs a listen shape?

A 'Delay' is very much similar to a sleep on the current thread. A 'Listen' shape is used to wait for an incoming resource, with a timeout period.
3. When you use Call Orchestration shape vs Start Orchestration shape?

A Call Orchestration returns the control back to the caller. A Start Ochestration shape starts the orchestration in a non-deterministic way.
4. What is the difference between a "Message Assignment" shape and an "Expression" shape?

A "Message Assignment" shape is used to create a new message and assign values to it. A Expression shape is used to assign values to variables and also write 'if' conditions.
5. Does BizTalk Orchestrations support recursion?

An Orchestration does NOT support recursion.
6. What is the purpose of the property "Activate" in a Receive shape?

It is used to invoke a new instance of an Orchestration.
7. Can an orchestration Start without an Activatable receive?

A Nested Orchestration can be started without an Activatable receive
8. Is it necessary for all .NET components being called from an Orchestration be Serializable?

Yes it is necessary. There are cases where a .NET component need not be Serializable.
9. When do we need set the property "Synchronized" = true for a scope?

This needs to be set, when a variable is shared across the branches of a parallel shape.
10. What is the difference between an Exception block and a Compensation block?
 is it the equivalent of try-catch-finally?

Refer to HOW To Compensate a Transaction in a BizTalk Orchestration
11. Is it possible to have a exception block for an Atomic scope?
 if not why?

Refer to Parallel Branching and Scoping in BizTalk Orchestrations - Advanced Concepts
12. How does one enable Correlations in BizTalk?

First create a Correlation type and then create an instance of it.
13. Is it possible to share variables across two branches in a Parallel shape?

Refer to Parallel Branching and Scoping in BizTalk Orchestrations - Advanced Concepts
14. Does BizTalk automatically compensate a unsuccessful transaction?

Refer to HOW To Compensate a Transaction in a BizTalk Orchestration
15. What is the main difference between a Long-Running transaction and an Atomic Transaction in BizTalk context?

Refer to HOW To Compensate a Transaction in a BizTalk Orchestration
Architecture and Design
1. In an Orchestration design, Orchestration "A" calls another Orchestration "B", and vice versa. Is it possible to implement this design?

It is NOT possible, since it forms a cyclic dependency.
2. List out the three important things to consider while designing a BizTalk orchestration!
The Incoming data format, The Business process and The Outgoing data format.
3. Enumerate the steps required to deploy an BizTalk solution from one machine to another machine.
Refer to Using the MSI installer wizard for deploying applications created in BizTalk Server 2006
What is BizTalk?

+ Biztalk
What is BizTalk?

+ The BizTalk Framework is a set of guidelines for driving the consistent adoption of XML to enable e-Commerce and application integration.
Message Type (i.e. BTS.MessageType)
+ Biztalk
Biztalk
+ Message Type (i.e. BTS.MessageType)
+ Messages in BizTalk are data, and each message must be of a selected message type.
Distinguished field and Promoted Property
+ Biztalk
Distinguished field and Promoted Property
+ The two ways to programmatically access an attribute or element in BizTalk are Distinguished Field and Promoted Property
What is direct binding?

+ Biztalk
What is direct binding?

+ Direct binding in Biztalk Server 2004 can be used to send messages from one Orchestration to another and can also be used to send messages directly into the message box.
What is BAM?

+ Biztalk
What is BAM?

+ Microsoft documentation describes BAM as “Business Activity Monitoring (BAM)
What is the Rules Engine?

+ Biztalk
What is the Rules Engine?

+ BizTalk Rules Engine provides a framework to enable the implementation, deployment, and versioning of your business logic in a quick and extensible manner.
What are Persistence Points?

+ Biztalk
What are Persistence Points?

+ The process of saving your running orchestration state at certain point is called persistence.
What is convoy and correlation sets?

+ Biztalk

#### What is convoy and correlation sets?

+ A correlation set is a set of properties with specific values.
+ The correlation set can have a maximum of three properties used for correlation on the receive shapes.
+ A correlation type is a list of properties that eventually populates with values for use in routing messages.
+ A convoy exists any time that multiple single messages must be related to achieve the required result.
+ An orchestration instance might receive a group of correlated messages simultaneously, under certain conditions. BizTalk Server detects the potential for this race condition and treats these messages as a convoy so as to ensure that all of the correlated messages are received by the same orchestration instance.
+ The runtime creates a general subscription and identifies it as part of a convoy at enlistment.
+ After filling this subscription, the messaging engine creates a temporary subscription based on the values in the predefined correlation properties called a convoy set.
+ Thus, a convoy set is a group of correlation sets that are used in a convoy. All messages that match the general subscription are evaluated against the convoy set, and those that match are routed to an existing port.
+ There are two main types of convoys: sequential and parallel.

#### What is convoy and correlation sets?

BizTalk server detects the potential for certain race conditions, which are ensured that all correlated messages are received by the same orchestration instance. The potentiality of these race conditions is detected by BizTalk server. These messages are treated as a ‘convoy’. A convoy set is a group of correlation sets. All such subsequent messages which match the general subscription are evaluated against the convoy set, and the matched convoys are routed to an existing port.

+ A correlation set is a set of properties with specific values. 
+ The correlation set can have a maximum of three properties used for correlation on the receive shapes.

#### Message routing and Content routing

+ Message routing: is a method of passing through BizTalk without being processed.
+ Content routing: is a method of passing of the message which is based on certain field value of the schema.

#### Document Schema and Property Schema

+ A property schema enables you to define promoted properties in a common location and have them referenced by other schemas.

#### What are Un-typed and Typed messages?

+ When a message created in BizTalk Orchestration is bound to a schema, this is a typed message.
+ In un-typed messages, the message is bound to `System.Xml.XmlDocument` instead of a schema. Thus, an un-typed message is one whose message type is set to `XmlDocument` in an orchestration.


#### BizTalk Server and Web Services 

+ BizTalk is a product while Web Services are a standard.

#### BizTalk Server Messaging Services

+ A Message is the heart of the BizTalk Server. 
+ The messaging service in BizTalk allows provides communication within the Server as well as the outside it.

#### BizTalk Orchestration

+ Business analysts and developers can dramatically simplify the integration and automation of business interactions inside and between companies using BizTalk Orchestration.

#### BizTalk Orchestration XLANG Scheduler Engine 

+ XLANG schedule running instances: Instantiation, execution, dehydration (occurs when the XLANG Scheduler Engine has to wait for greater than three minutes to receive a message) 
+ re-hydration (occurs when the message arrives to the XLANG Scheduler Engine)

#### Components of Biztalk Server architecture

+ Receive Port: listens for messages. 
+ Adapters: information interchange with external systems

#### Business Activity Services (BAS) - Trading Partner Management 

+ Information workers Manage trading partner relationships within organizations.

#### Static, dynamic and direct binding

+ Static Binding: A static port is already configured at the time of deployment to use a transport so as to deliver messages to a specific external end point.

#### Transfer files without using Orchestration

+ Use content Base routing, you can create a filter on the send port that checks the receive location specified in the envelope.

#### What is Biztalk Server? Since when are you working on BizTalk?

#### What versions of Biztalk Server have you worked on?

#### What is the difference between 2004, 2006 and 2006R2?

#### Did you get chance to work on BizTalk 2009 version? If yes what difference you saw in it from R2 and what enhancements Microsoft has made in it?

#### Tell me about BizTalk Server architecture?

#### Tell me about any engagement which you rate top most while working as BizTalk developer and why?

#### Most Imp: Tell about a project which was most challenging to you and how you overcame it?

#### What do you hate about BizTalk Solution development and which you would like to improve in upcoming versions?

#### How you do testing with your BizTalk Solutions and what tools or methods you use?

#### How do you debug any errors occurring in BizTalk Solution?

#### How do you debug an assembly used in Orchestration?

#### Which way you find most efficient debugging Biztalk Solutions and why?

#### Were you involved in designing BizTalk Solutions? If yes than what kinds of architecture you have designed?

#### What design patterns you follow for designing solutions with BizTalk in it?

#### What do you know about Itinerary based routing architecture?

#### Did you ever got chance to work on ESB's? If yes, tell me more about it?

#### Tell about BizTalk Solution development lifecycle?

#### What kinds of Integrations you have done with BizTalk Server?

#### What challenges you faced while designing and developing a Biztalk solution which involved multiple non MS platform technologies? How did you overcome them?

#### What different kinds of Adapters you have worked on?

#### Have you worked on SAP Adapters? Why did you opt using SAP adpaters instead of communicating with Web Services?

#### Have you worked on Salesforce.com integration in any of your engagements? If than tell me more about it.

#### What challenges you faced while working with Salesforce.com?

#### Have you worked on EDI documents? What kind of EDI documents have you worked on?

#### What different types of industries you have worked on? Which one you found most challenging and why?

#### Were you involved in developing Custom components for BizTalk Solutions? If yes than what were those?

#### Have you developed and used any Custom Pipeline Components? how did you develop them and later used in BizTalk Solution? What challenges you faced using custom pipeline components?

#### What kind of environments you have worked on?

#### Have you worked on environments containing multiple BizTalk box installed? If yes than what different kinds of configurations were there?

#### Were you involved in administrating Biztalk solutions?

#### Tell me how you deploy your BizTalk solutions? Do you use any tools or API's for deployment?

#### How do you deploy your solution on multiple BizTalk boxes easily and efficiently? What issues have you faced doing that?

#### Have you worked with Business Rules Engine? Tell me about the BRE architecture?

#### How does a rule gets actually fired or processed in an orchestration?

#### Have you worked with Business Rules apart from using them in Orchestrations?

#### What are the different ways you can call a Business Rule in Orchestration? Which way you find most efficient and why?

#### Have you worked with BAM? What is BAM and why did you use in your particular project?

#### How did you develop a Biztalk solution with BAM in it?

#### What deployment steps you apply to deploy BAM?

#### Which are different BAM Databases? Have you manually deleted any BAM data? If yes than how?

#### What is the easiest way to develop a schema from an given XML message?

#### Have you worked on a architecture having WCF Services? If yes than tell me more about that architecture?

#### How would you rate using Web Services over WCF Services in BizTalk solution? Why?

#### Have you ever exposed you BizTalk Solution as a Service - How?

#### Have you ever felt that using BizTalk at a place was not a good option?

#### What types of different capabilities of BizTalk Server you have worked on?

#### What do you know about transactions in BizTalk Solutions?

#### What is Atomic/Long Running transaction?

#### When do you use them and when not?

#### How do you handle your exceptions occurring in BizTalk Solutions?

#### Do you follow any particular standard to handle exceptions?

#### What are the most important things to keep in mind while designing BizTalk Solution Architecture?

#### What size of architectures you have worked on and how many multiple Enterprise Systems were involved in it?

#### How much time it took for you to design and develop it?

#### What was the team structure for that engagement?

#### What Is a BizTalk Application?

A BizTalk application is a logical grouping of the items, called "artifacts," used in a BizTalk Server business solution. Artifacts include the following:
+ BizTalk assemblies and the BizTalk-specific resources that they contain – orchestrations, pipelines, schemas, and maps
+ .NET assemblies that do not contain BizTalk-specific resources
+ Policies
+ Send ports, send port groups & send port locations
+ Receive locations & receive ports
+ Other items that are used by the solution, such as certificates, COM components, and scripts

#### What is the lifecycle of a Message in BizTalk server?

+ A message is received through a receive location defined in a given receive port. 
+ This message is processed by the pipeline associated with the receive location, and if there are any inbound maps associated with the receive port they are executed.
+ The resulting message is then published to the MessageBox database.
+ The MessageBox evaluates active subscriptions and routes the message to those orchestrations, and send ports with matching subscriptions.
+ Orchestrations may process the message and publish messages through the MessageBox to a send port where it is pushed out to its final destination.

#### BizTalk support synchronous communication?

BizTalk Server architecture is asynchronous for scalability reasons. However, the architecture of the BizTalk Messaging Engine enables exposing a synchronous message exchange pattern on top of these asynchronous exchanges. To do this, the engine handles the complex task of correlating the request and response messages across a scaled-out architecture by linking together a number of asynchronous message exchanges to expose a synchronous interface.

#### Can an envelope schema consist of more than one schema type?

Yes. XML envelopes serve two purposes within XML instance messages sent and received by Microsoft BizTalk Server:
+ XML envelopes can contain data that supplements the data within the XMLdocuments. This data can be promoted into the message context by the XML disassembler to provide easier access from a variety of BizTalk Server components. For outbound XML instance messages, the XML assembler can demote values from the message context into an envelope for inclusion in the instance message transmission.
+ XML envelopes can be used to combine multiple XML documents into a single, valid XML instance message. Without an envelope to wrap multiple documents within a single root tag, an XML instance message containing multiple documentswould not qualify as well-formed XML.

#### What are the execution modes in a pipeline Stage?

+ A stage in a pipeline has an execution mode of either “All” or “First Match”, which controls the components that get executed if more than one component is added to a stage.
	+ For stages with a mode of “All”, each component is called to process the message in the order in which they are configured in the stage.
	+ For stages with a mode of “First Match”, each component is polled to indicate that it is the right component until a match is found, at which point the component that matches is executed, while the remaining components do not get executed.

#### Which Interfaces do you need to implement in a disassembling custom pipeline component?

+ A disassembling pipeline component receives one message on input and produces zero or more messages on output. 
+ Disassembling components are used to split interchanges of messages into individual documents. 
+ Disassembler components must implement the following interfaces:
	+ IBaseComponent.
	+ IDisassemblerComponent.
	+ IComponentUI.
	+ IPersistPropertyBag.

#### What is a link in a Map?

+ A link specifies the basic function of copying data from an element or attribute in an input instance message to an element or attribute in an output instance.
+ You create links between records and fields in the source and destination schemas at design time. This drives the creation, at run time, of an output instance message conforming to the destination schema from an input instance message conforming to the source schema.

#### How to route binary data?

+ To route binary data you can use pass-through pipelines on the receive location and send port. 
+ BizTalk will route (copy) the data from the source (receive location) to the destination (send port). 
+ If you want to route the binary data based on some information in the binary data then you write a custom Disassembler to promote the properties you need from the incoming message to route the binary data.

#### Why did we build BizTalk36O — Throttling Analyzer?

Throttling is difficult to understand
+ BizTalk Server only provides raw performance counter data and no visual tools
+ Traditional performance monitoring tools (ex: perfmon) not suited for monitoring throttling
+ Companies don’t monitor the throttling conditions in real time.

### BizTalk36O Features

BizTalk360 tool makes the BizTalk environment simple, secure, effective and more manageable. 

**Features**
+ Graphical message flow
+ Knowledge Base
+ Advanced Event viewer
+ Throttling Analyzer
+ Backup DR (Disaster Recovery DB)

#### The benefits of strong naming your assembly

Strong naming your assembly allows you to include your assembly into the Global Assembly Cache (GAC). Thus it allows you to share it among multiple applications.

Strong naming guarantees a unique name for that assembly. Thus no one else can use the same assembly name.

Strong name protect the version lineage of an assembly. A strong name can ensure that no one is able to produce a subsequent version of your assembly. Application users are ensured that a version of the assembly they are loading come from the same publisher that created the version the application was built with.

Strong named assemblies are signed with a digital signature. This protects the assembly from modification. Any tampering causes the verification process that occurs at assembly load time to fail. An exception is generated and the assembly is not loaded.
