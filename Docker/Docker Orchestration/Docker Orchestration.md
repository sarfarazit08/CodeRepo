# Docker Orchestration

## Contents
1. Introduction
2. Getting Started with Docker Swarm
3. Managing Docker Swarm
4. Troubleshooting Docker Swarm
5. Conclusion

### 1.Introduction:
01. Welcome
02. Docker Certified Associate (DCA) prep
03. What you should know
04. Setting up your environment

### 2. Getting Started with Docker Swarm:
05. Introducing Docker Swarm
06. Set up a Docker Swarm cluster
07. Nodes, services, containers, and tasks
08. Locking a Swarm cluster
09. Why Quorum is important

### 3. Managing Docker Swarm:
10. Visualizing Swarm services
11. Analyzing services with Docker Inspect
12. Understanding stacks and stack files
13. Manipulate a running stack of services
14. Modifying network ports
15. Mounting volumes
16. Replicated vs global services

### 4. Troubleshooting Docker Swarm:
17. Troubleshooting a service
18. Using labels
19. Understanding container communications
20. Using templates with Docker services

### 5. Conclusion:
21. Next steps

<br>

<img src="./screens/DockerOrch-00002.jpg" alt="screens" />
<img src="./screens/DockerOrch-00003.jpg" alt="screens" />
<img src="./screens/DockerOrch-00004.jpg" alt="screens" />
<img src="./screens/DockerOrch-00005.jpg" alt="screens" />
<img src="./screens/DockerOrch-00006.jpg" alt="screens" />
<img src="./screens/DockerOrch-00007.jpg" alt="screens" />
<img src="./screens/DockerOrch-00008.jpg" alt="screens" />
<img src="./screens/DockerOrch-00009.jpg" alt="screens" />
<img src="./screens/DockerOrch-00010.jpg" alt="screens" />
<img src="./screens/DockerOrch-00011.jpg" alt="screens" />
<img src="./screens/DockerOrch-00012.jpg" alt="screens" />
<img src="./screens/DockerOrch-00013.jpg" alt="screens" />
<img src="./screens/DockerOrch-00014.jpg" alt="screens" />
<img src="./screens/DockerOrch-00015.jpg" alt="screens" />
<img src="./screens/DockerOrch-00016.jpg" alt="screens" />
<img src="./screens/DockerOrch-00017.jpg" alt="screens" />
<img src="./screens/DockerOrch-00018.jpg" alt="screens" />
<img src="./screens/DockerOrch-00019.jpg" alt="screens" />
<img src="./screens/DockerOrch-00020.jpg" alt="screens" />
<img src="./screens/DockerOrch-00021.jpg" alt="screens" />
<img src="./screens/DockerOrch-00022.jpg" alt="screens" />
<img src="./screens/DockerOrch-00023.jpg" alt="screens" />
<img src="./screens/DockerOrch-00024.jpg" alt="screens" />
<img src="./screens/DockerOrch-00025.jpg" alt="screens" />
<img src="./screens/DockerOrch-00026.jpg" alt="screens" />
<img src="./screens/DockerOrch-00027.jpg" alt="screens" />
<img src="./screens/DockerOrch-00028.jpg" alt="screens" />
<img src="./screens/DockerOrch-00029.jpg" alt="screens" />
<img src="./screens/DockerOrch-00030.jpg" alt="screens" />
<img src="./screens/DockerOrch-00031.jpg" alt="screens" />
<img src="./screens/DockerOrch-00032.jpg" alt="screens" />
<img src="./screens/DockerOrch-00033.jpg" alt="screens" />
<img src="./screens/DockerOrch-00034.jpg" alt="screens" />
<img src="./screens/DockerOrch-00035.jpg" alt="screens" />
<img src="./screens/DockerOrch-00036.jpg" alt="screens" />
<img src="./screens/DockerOrch-00037.jpg" alt="screens" />
<img src="./screens/DockerOrch-00038.jpg" alt="screens" />
<img src="./screens/DockerOrch-00039.jpg" alt="screens" />
<img src="./screens/DockerOrch-00040.jpg" alt="screens" />
<img src="./screens/DockerOrch-00041.jpg" alt="screens" />
<img src="./screens/DockerOrch-00042.jpg" alt="screens" />
<img src="./screens/DockerOrch-00043.jpg" alt="screens" />
<img src="./screens/DockerOrch-00044.jpg" alt="screens" />
<img src="./screens/DockerOrch-00045.jpg" alt="screens" />
<img src="./screens/DockerOrch-00046.jpg" alt="screens" />
<img src="./screens/DockerOrch-00047.jpg" alt="screens" />
<img src="./screens/DockerOrch-00048.jpg" alt="screens" />
<img src="./screens/DockerOrch-00049.jpg" alt="screens" />
<img src="./screens/DockerOrch-00050.jpg" alt="screens" />
<img src="./screens/DockerOrch-00051.jpg" alt="screens" />
<img src="./screens/DockerOrch-00052.jpg" alt="screens" />
<img src="./screens/DockerOrch-00053.jpg" alt="screens" />
<img src="./screens/DockerOrch-00054.jpg" alt="screens" />
<img src="./screens/DockerOrch-00055.jpg" alt="screens" />
<img src="./screens/DockerOrch-00056.jpg" alt="screens" />
<img src="./screens/DockerOrch-00057.jpg" alt="screens" />
<img src="./screens/DockerOrch-00058.jpg" alt="screens" />
<img src="./screens/DockerOrch-00059.jpg" alt="screens" />
<img src="./screens/DockerOrch-00060.jpg" alt="screens" />
<img src="./screens/DockerOrch-00061.jpg" alt="screens" />
<img src="./screens/DockerOrch-00062.jpg" alt="screens" />
<img src="./screens/DockerOrch-00063.jpg" alt="screens" />
<img src="./screens/DockerOrch-00064.jpg" alt="screens" />
<img src="./screens/DockerOrch-00065.jpg" alt="screens" />
<img src="./screens/DockerOrch-00066.jpg" alt="screens" />
<img src="./screens/DockerOrch-00067.jpg" alt="screens" />
<img src="./screens/DockerOrch-00068.jpg" alt="screens" />
<img src="./screens/DockerOrch-00069.jpg" alt="screens" />
<img src="./screens/DockerOrch-00070.jpg" alt="screens" />
<img src="./screens/DockerOrch-00072.jpg" alt="screens" />
<img src="./screens/DockerOrch-00073.jpg" alt="screens" />
<img src="./screens/DockerOrch-00074.jpg" alt="screens" />
<img src="./screens/DockerOrch-00075.jpg" alt="screens" />
<img src="./screens/DockerOrch-00076.jpg" alt="screens" />
<img src="./screens/DockerOrch-00077.jpg" alt="screens" />
<img src="./screens/DockerOrch-00078.jpg" alt="screens" />
<img src="./screens/DockerOrch-00079.jpg" alt="screens" />
<img src="./screens/DockerOrch-00080.jpg" alt="screens" />
<img src="./screens/DockerOrch-00081.jpg" alt="screens" />
<img src="./screens/DockerOrch-00082.jpg" alt="screens" />
<img src="./screens/DockerOrch-00083.jpg" alt="screens" />
<img src="./screens/DockerOrch-00084.jpg" alt="screens" />
<img src="./screens/DockerOrch-00085.jpg" alt="screens" />
<img src="./screens/DockerOrch-00086.jpg" alt="screens" />
<img src="./screens/DockerOrch-00087.jpg" alt="screens" />
<img src="./screens/DockerOrch-00088.jpg" alt="screens" />
<img src="./screens/DockerOrch-00089.jpg" alt="screens" />
<img src="./screens/DockerOrch-00090.jpg" alt="screens" />
<img src="./screens/DockerOrch-00091.jpg" alt="screens" />
<img src="./screens/DockerOrch-00092.jpg" alt="screens" />
<img src="./screens/DockerOrch-00093.jpg" alt="screens" />
<img src="./screens/DockerOrch-00094.jpg" alt="screens" />
<img src="./screens/DockerOrch-00095.jpg" alt="screens" />
<img src="./screens/DockerOrch-00096.jpg" alt="screens" />
<img src="./screens/DockerOrch-00097.jpg" alt="screens" />
<img src="./screens/DockerOrch-00098.jpg" alt="screens" />
<img src="./screens/DockerOrch-00099.jpg" alt="screens" />
<img src="./screens/DockerOrch-00100.jpg" alt="screens" />
<img src="./screens/DockerOrch-00101.jpg" alt="screens" />
<img src="./screens/DockerOrch-00102.jpg" alt="screens" />
<img src="./screens/DockerOrch-00103.jpg" alt="screens" />
<img src="./screens/DockerOrch-00104.jpg" alt="screens" />
<img src="./screens/DockerOrch-00105.jpg" alt="screens" />
<img src="./screens/DockerOrch-00106.jpg" alt="screens" />
<img src="./screens/DockerOrch-00107.jpg" alt="screens" />
<img src="./screens/DockerOrch-00108.jpg" alt="screens" />
<img src="./screens/DockerOrch-00109.jpg" alt="screens" />
<img src="./screens/DockerOrch-00110.jpg" alt="screens" />
<img src="./screens/DockerOrch-00111.jpg" alt="screens" />
<img src="./screens/DockerOrch-00112.jpg" alt="screens" />
<img src="./screens/DockerOrch-00113.jpg" alt="screens" />
<img src="./screens/DockerOrch-00114.jpg" alt="screens" />
<img src="./screens/DockerOrch-00115.jpg" alt="screens" />
<img src="./screens/DockerOrch-00116.jpg" alt="screens" />
<img src="./screens/DockerOrch-00117.jpg" alt="screens" />
<img src="./screens/DockerOrch-00118.jpg" alt="screens" />
<img src="./screens/DockerOrch-00119.jpg" alt="screens" />
<img src="./screens/DockerOrch-00120.jpg" alt="screens" />
<img src="./screens/DockerOrch-00121.jpg" alt="screens" />
<img src="./screens/DockerOrch-00122.jpg" alt="screens" />
<img src="./screens/DockerOrch-00123.jpg" alt="screens" />
<img src="./screens/DockerOrch-00124.jpg" alt="screens" />
<img src="./screens/DockerOrch-00125.jpg" alt="screens" />
<img src="./screens/DockerOrch-00126.jpg" alt="screens" />

<br>

### The End :)