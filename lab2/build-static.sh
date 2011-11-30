#!/usr/bin/env bash

fsharpc $1.fs
mkbundle -o $1 $1.exe --deps --static
rm -f $1.exe
