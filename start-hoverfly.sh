#!/bin/bash

git submodule update --init --recursive --merge
docker-compose -f simengine/docker-compose.yaml up -d
hoverctl -t remote import simengine/rpc/rpc.json
