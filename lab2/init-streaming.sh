#!/usr/bin/env bash

. /usr/share/hadoop/bin/hadoop-config.sh

$HADOOP_HOME/bin/hadoop dfs -mkdir lorem
$HADOOP_HOME/bin/hadoop dfs -put $PWD/lorem.txt lorem/
