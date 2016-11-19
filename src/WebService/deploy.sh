#!/bin/bash
# Must be logged in first with...
# aws ecr get-login --region us-west-2

dotnet publish

docker build -t treeloop/classroomservice bin/Debug/netcoreapp1.0/publish

docker tag treeloop/classroomservice:latest 376187332115.dkr.ecr.us-west-2.amazonaws.com/treeloop/classroomservice:latest

docker push 376187332115.dkr.ecr.us-west-2.amazonaws.com/treeloop/classroomservice:latest