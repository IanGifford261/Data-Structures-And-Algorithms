# LinkedList

**Author**: Ian Gifford
**Version**: 1.0.0

## Overview
A Challenge that implements a method that takes a string as an argument and checks if that string contains proper opening/closing brackets.

## Example
![]()

## Approach & Efficiency
We have counters that really on keep track for the closing bracket first issue
We have a stack and a queue, the stack keeps track of opening braces, the queue tracks closing. We pop the stack and dequeue the queue and check if the values are the appropriate pair. If not, return false

## Note on the UML
This works, if the second 'stack' is actually a queue. The lines don't go straight across to each other. They point diagonally

## Architecture
Microsoft Visual Studio Community
Xunit

## Change Log
V1.0 "building out" 08 APR 2019
