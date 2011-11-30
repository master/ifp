#!/usr/bin/env bash
# Source: http://hadoop.apache.org/common/docs/r0.20.2/quickstart.html

. /usr/share/hadoop/bin/hadoop-config.sh

$HADOOP_HOME/bin/hadoop namenode -format
$HADOOP_HOME/bin/start-dfs.sh
$HADOOP_HOME/bin/start-mapred.sh 
