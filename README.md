# Abstract Factory Design Pattren => Creational

What is Abstract Factory Design Pattern
 
Gang Of Four Definition : "The Abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes"

The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes

Abstract Factory pattern belongs to creational patterns and is one of the most used design patterns in real world applications

Abstract factory is a super factory that creates other factories

Implementation Guidelines

We need to Choose Abstract Factory Pattern when
1. The application need to create multiple families of objects or products
2. We need to use only one of the subset of families of objects at a given point of time
3. We want to hide the implementations of the families of products by decoupling the implementation of each of these operations

Business Requirement : Handout computers to Contract and Permanent employees based on the designation and employee type with below specifications

Permanent Employee 
1. Managerial Position is eligible for Apple MAC Book Laptop
2. Non Managerial Position is eligible for Apple IMac desktop

Contract Employee
1. Managerial Position is eligible for Dell Laptop
2. Non Managerial Position is eligible for Dell desktop

Abstract Factory Representation
1. Client is a class which use AbstractFactory and AbstractProduct interfaces to create a family of related objects.
2. AbstractFactory is an interface which is used to create abstract product
3. ConcreteFactory is a class which implements the AbstractFactory interface to create concrete products.
4. AbstractProduct  is an interface which declares a type of product.
5. ConcreteProduct is a class which implements the AbstractProduct interface to create product.
