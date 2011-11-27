#!/usr/bin/env python2
import networkx as nx

def generate(nodes, conn, name):
    # As per Duncan J. Watts and Steven H. Strogatz, Collective dynamics
    # of small-world networks, Nature, 393, pp. 440-442, 1998.
    G = nx.generators.connected_watts_strogatz_graph(nodes, conn, 0.3)
    f = open("%s.txt" % name, "w")
    for v in G.nodes_iter():
        neighbors = " ".join([str(w) for w in G.neighbors_iter(v)])
        f.write("%s\t%s\n" % (v, neighbors))
    f.close()
    nx.write_dot(G, "%s.dot" % name)

if __name__ == "__main__":
    generate(100, 10, "small-100")
    # 120 is Dunbar's number
    generate(10000, 120, "large-10k")
