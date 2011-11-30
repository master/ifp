#!/usr/bin/env python2
import sys

for line in sys.stdin:
    line = line.strip()
    words = line.split()
    for word in words:
        # tab-delimited; the trivial word count is 1
        print '%s\t%s' % (word, 1)
