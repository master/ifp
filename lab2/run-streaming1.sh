#!/usr/bin/env bash

. /usr/share/hadoop/bin/hadoop-config.sh

$HADOOP_HOME/bin/hadoop jar $HADOOP_HOME/hadoop-streaming.jar \
    -input lorem \
    -output out1 \
    -inputformat KeyValueTextInputFormat \
    -mapper org.apache.hadoop.mapred.lib.IdentityMapper \
    -reducer org.apache.hadoop.mapred.lib.IdentityReducer
