#!/usr/bin/env python2
# -*- coding: utf-8 -*-
import networkx as nx

def save(G, name):
    f = open("%s.txt" % name, "w")
    for v in G.nodes_iter():
        neighbors = " ".join([str(w) for w in G.neighbors_iter(v)])
        f.write("%s\t%s\n" % (v, neighbors))
    f.close()
    nx.write_dot(G, "%s.dot" % name)

if __name__ == "__main__":
    # As per Duncan J. Watts and Steven H. Strogatz, Collective dynamics
    # of small-world networks, Nature, 393, pp. 440-442, 1998.
    G = nx.generators.connected_watts_strogatz_graph(100, 10, 0.3)
    save(G, "ws_100_10")

    # 120 is Dunbar's number    
    G = nx.generators.connected_watts_strogatz_graph(10000, 120, 0.3)
    save(G, "ws_10k_120")

    # As per A. L. Barabási and R. Albert “Emergence of scaling in random
    # networks”, Science 286, pp 509-512, 1999.
    G = nx.barabasi_albert_graph(100, 10)
    save(G, "ba_100_10")

    G = nx.barabasi_albert_graph(40000, 120)
    save(G, "ba_40k_120")    
