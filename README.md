# GraphQL Example for C# and Entity Framewok 

GraphQL is a query language for your API and a server-side runtime for executing queries using a type system that you define for your data. GraphQL is not tied to any specific database or storage engine and is instead supported by existing code and data.

This way, GraphQL facilitates the process of delivering to the customer only what was requested by the same and in the order in which it was requested.

It can be understood as an abstraction to the HTTP protocol where you use an endpoint that uses a GraphQL server that will receive POST and GET requests responding in JSON format.

Some concepts used in the GraphQL ecosystem:

Schema - Describes the functionality available to clients connecting to it.

Types - Everything in GraphQL is a type, and a type can be understood as an entity in your database (relational or non-relational). The types form a schema, and GraphQL has 2 default types: RootQuery and RootMutation.

Query and Mutations - The type Query is to define the data query contract and The type Mutation is to define the data manipulation contract

Resolver - Resolvers are functions responsible for resolving an order and returning the requested data. Functions take three arguments: root , arguments and context.

It is important to point out that although GraphQL is a query language for APIs, it is different from REST, in fact it competes like REST.

Some advantages of GraphQL:

Limit the number of endpoints
Clients have the ability to dictate exactly what they need from the server and receive that data in a predictable manner.
