# 14. UML

>Unified Modeling Language (UML) is a general-purpose modeling language

UML is for visualizing desing of system


>**references**
>- geeks for geeks: [uml](https://www.geeksforgeeks.org/system-design/unified-modeling-language-uml-introduction/)

![enter image description here](https://media.geeksforgeeks.org/wp-content/uploads/20231222121300/UML-Diagrams.jpg)

# Types
-	[Structural](#structural)
	-	[class](#class-uml)
-	[Behavioral](#behavioral)
	-	[sequence](#sequence-uml)
	-	[use case](#use-case-uml)


# Structural
##	Class UML
![enter image description here](https://media.geeksforgeeks.org/wp-content/uploads/20241010144554871458/Class-Diagram-example.webp)
### Notation
![enter image description here](https://media.geeksforgeeks.org/wp-content/uploads/20240118123645/Class-Notation.webp)


### - Name
	-   `+` for public (visible to all classes)
	-  	 `-` for private (visible only within the class)
	-   `#` for protected (visible to subclasses)
	-   `~` for package or default visibility (visible to classes in the same package)


### - Relations
![enter image description here](https://media.geeksforgeeks.org/wp-content/uploads/20240209094815/relationship.webp)
#### 1. Association

An association represents a bi-directional relationship between two classes. It indicates that instances of one class are connected to instances of another class. Associations are typically depicted as a solid line connecting the classes, with optional arrows indicating the direction of the relationship.

#### 2. Directed Association

A directed association in a UML class diagram represents a relationship between two classes where the association has a direction, indicating that one class is associated with another in a specific way.

#### 3. Aggregation

Aggregation is a specialized form of association that represents a "whole-part" relationship. It denotes a stronger relationship where one class (the whole) contains or is composed of another class (the part). Aggregation is represented by a diamond shape on the side of the whole class. In this kind of relationship, the child class can exist independently of its parent class.

#### 4. Composition

Composition is a stronger form of aggregation, indicating a more significant ownership or dependency relationship. In composition, the part class cannot exist independently of the whole class. Composition is represented by a filled diamond shape on the side of the whole class.

#### 5. Generalization(Inheritance)

Inheritance represents an "is-a" relationship between classes, where one class (the subclass or child) inherits the properties and behaviors of another class (the superclass or parent). Inheritance is depicted by a solid line with a closed, hollow arrowhead pointing from the subclass to the superclass.

#### 6. Realization (Interface Implementation)

Realization indicates that a class implements the features of an interface. It is often used in cases where a class realizes the operations defined by an interface. Realization is depicted by a dashed line with an open arrowhead pointing from the implementing class to the interface.

#### 7. Dependency Relationship

A dependency exists between two classes when one class relies on another, but the relationship is not as strong as association or inheritance. It represents a more loosely coupled connection between classes.

#### 8. Usage(Dependency) Relationship

A usage dependency relationship in a UML class diagram indicates that one class (the client) utilizes or depends on another class (the supplier) to perform certain tasks or access certain functionality. The client class relies on the services provided by the supplier class but does not own or create instances of it.

-   In UML class diagrams, usage dependencies are typically represented by a dashed arrowed line pointing from the client class to the supplier class.
-   The arrow indicates the direction of the dependency, showing that the client class depends on the services provided by the supplier class.

# Behavioral
## Sequence UML
![sequence](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjbQnn-RZR0jc_W0csDwpyMAHbJCnuikbbu-kKtrum_GyFTjyYS77e2OqtzcOQpEuceAhvHHs2W0mFkx_DGvrTP1IgiBU8kPv91MqTZ3yfWW_-NIc30eYbr5h5aczR9dsY9hKSDwqX-IqXX/s1600/2010-09-5+OO+-+UML+Behavior+Diagrams+5.gif)

## Use Case UML
![enter image description here](https://media.geeksforgeeks.org/wp-content/uploads/20241010150547377799/Use-Case-diagram-of-an-Online-Shopping-System.webp)
<!--stackedit_data:
eyJoaXN0b3J5IjpbMTk3NjE4ODYzMSwtMTkyODI0MDE4OSw2Nj
c1MTA4MjksLTE4MTQzMTUyODEsNjg5NjY0MDU3LC0xMzI5OTU3
MjU1LDU4Njk2Nzk3NCwtMTAyMTQ4MzYxOCw4NTY4MzU5OTddfQ
==
-->