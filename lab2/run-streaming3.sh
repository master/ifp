#!/usr/bin/env bash

. /usr/share/hadoop/bin/hadoop-config.sh

$HADOOP_HOME/bin/hadoop dfs -mkdir lorem
$HADOOP_HOME/bin/hadoop dfs -put $PWD/lorem.txt lorem/
$HADOOP_HOME/bin/hadoop jar $HADOOP_HOME/hadoop-streaming.jar \
    -input lorem \
    -output lorem_out \
    -mapper $PWD/mapper.py \
    -reducer $PWD/reducer.py

