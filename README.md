[TOC]

# About

## Purpose

The purpose of this library is to provide interfaces for a flexible and robust state machine. 

One of the main goals is to not only build a state machine being able to switch states, but also to handle transitions.

You are able to add actions to the following events:

- State
  - Enter
  - Update
  - Exit
- Transition
  - Enter
  - in Between
  - Exit

## Why?

Why would you even want to use that high number of Actions here? It is because the pipeline is flexible enough to support scenarios where you can do specific actions for specific state transitions while still being able to have common state actions.

# How to use
A possible implementation with Tests and Examples can be found here: https://github.com/svrgn-eu/SVRGN.Libs.Implementations.StateMachine