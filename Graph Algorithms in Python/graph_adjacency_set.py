import abc

#################################################
# The base class representation of a Graph 
# with all the interface methods
#################################################

class Graph(abc.ABC):
    
    def __init__(self, numVertices, directed = False):
        self.numVertices = numVertices
        self.directed = directed
        
    @abc.abstractmethod
    def add_edge(self, v1, v2, weight):
        pass
    
    @abc.abstractmethod
    def get_adjacent_vertices(self, v):
        pass
    
    @abc.abstractmethod
    def get_indegree(self, v):
        pass
    
    @abc.abstractmethod
    def get_edge_weight(self, v1, v2):
        pass
    
    @abc.abstractmethod
    def display(self):
        pass


#############################################################
# A single node in a graph represented by an adjacency set.
# Every node has a vertex id.
# Each node is associated with a set of adjacent vertices.
#############################################################
class Node:
    
    def __init__(self, vertexId):
        self.vertextId = vertexId
        self.adjacency_set = set()
        
    def add_edge(self, v):
        if self.vertextId == v:
            raise ValueError("The vertex %d can not be adjacent to itself." % v)
            
        self.adjacency_set.add(v)
        
    def get_adjacent_vertices(self, v):
        return sorted(self.adjacency_set)


#############################################################
# Represents a graph as an Adjacency set.
# A graph is a list of nodes and each node has a set of adjacent vertices.
# This graph in this current form cannot be used to represent weighted edges
# Only Unweighted edges can be represented.
#############################################################

class AdjacencySetGraph(Graph):
    
    # Keep directed = True to make directed graph
    # Keep directed = False to make undirected graph
    
    def __init__(self, numVertices, directed = False): 
        super(AdjacencySetGraph,self).__init__(numVertices,directed)
        
        self.vertex_list = []
        for i in range(numVertices):
            self.vertex_list.append(Node(i))
            
    def add_edge(self, v1, v2, weight=1):
        if v1 >= self.numVertices or v2 >= self.numVertices or v1 < 0 or v2 < 0:
            print("Vertices %d and %d are out of bounds." % (v1,v2))
            
        # Represent only Unweighted Graphs (edge weights can't be greater than 1)
        if weight != 1: 
           print("An adjacency set cannot represent edge weights > 1")
        
        self.vertex_list[v1].add_edge(v2)
        
        if self.directed == False:
            self.vertex_list[v2].add_edge(v1)
    
    def get_adjacent_vertices(self, v):
        if v < 0  or v >= self.numVertices:
            print("Cannot access vertex %d" % v)
        
        return self.vertex_list[v].get_adjacent_vertices(v)
    
    def get_indegree(self, v):
        if v < 0  or v >= self.numVertices:
            print("Cannot access vertex %d" % v)
            
        indegree = 0
        for i in range(self.numVertices):
            if v in self.get_adjacent_vertices(i):
                indegree = indegree + 1
        
        return indegree
    
    def get_edge_weight(self, v1, v2):
        return 1
    
    def display(self):
        for i in range(self.numVertices):
            for v in self.get_adjacent_vertices(i):
                print(i, "-->", v)
    