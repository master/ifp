#!/usr/bin/env bash

. /usr/share/hadoop/bin/hadoop-config.sh

$HADOOP_HOME/bin/hadoop jar $HADOOP_HOME/hadoop-streaming.jar \
    -input lorem \
    -output out2 \
    -mapper /bin/cat \
    -reducer /usr/bin/wc
