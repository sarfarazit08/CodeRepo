import priority_dict
from graph_adjacency_matrix import *

def spanning_tree(graph):
    # Holds Mapping of vertex id to distance from source
    # Access the High Priority (Lowest Distance) item first
    priority_queue = priority_dict.priority_dict()
        
    for v in range(graph.numVertices):
        for neighbor in graph.get_adjacent_vertices(v):
            priority_queue[(v,neighbor)] = graph.get_edge_weight(v,neighbor)

    # To track visted vertices            
    visited_vertices = set()

    # Map a node to all its adjacent nodes 
    # which are in the minimum spanning tree
    spanning_tree = {}

    for v in range(graph.numVertices):
        spanning_tree[v] = set()

    # Number of edges we've got so far
    num_edges = 0
    
    while len(priority_queue.keys()) > 0 and num_edges < graph.numVertices - 1:
        v1, v2 = priority_queue.pop_smallest()

        # If we've already visited a vertex then we've all
        # outbound edges from it, we do not process it again
        if v1 in spanning_tree[v2]:
            continue

        # Arrange the spanning tree so that the node with smaller vertex id 
        # is always first. This greatly simplifies the code to find cycles in the tree
        vertex_pair = sorted([v1, v2])
        
        # add unvisited vertext to result set
        spanning_tree[vertex_pair[0]].add(vertex_pair[1])

        # check if adding current edge cause a cycle
        if has_cycle(spanning_tree):
            spanning_tree[vertex_pair[0]].remove(vertex_pair[1])
            continue

        num_edges = num_edges + 1

        visited_vertices.add(v1)
        visited_vertices.add(v2)

    print("Visited vertices ", visited_vertices)

    if len(visited_vertices) != graph.numVertices:
        print("Minimum Spanning Tree not found.")
    else:
        print("Minimum Spanning Tree:")
        for key in spanning_tree:
            for value in spanning_tree[key]:
                print(str(key) + "->" + str(value))

def has_cycle(spanning_tree):
    for source in spanning_tree:
        que = []
        que.append(source)

        visited_vertices = set()
        while len(que) > 0 :
            vertex = que.pop(0)

            # If we've seen the vertex before in 
            # the spanning tree there is a cycle
            if vertex in visited_vertices:
                return True

            visited_vertices.add(vertex)

            # Add all vertices connected by edges in this Spanning Tree
            que.extend(spanning_tree[vertex])

    return False
