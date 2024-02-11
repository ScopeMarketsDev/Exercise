# The Exercise

I want to write a new API which will allow me to store information about new customers. Instead of using a typical relational DB, I'm going to be an event sourcing pattern, so that I can easily keep track of the changes to my customer data.

I haven't got very far with this API yet, but here is my code, and we need to continue the implementation and see how far we can get.

If you clone this repo and open the solution, you should notice that it will run and show a Swagger page with one `POST /customers` API endpoint. If you try this endpoint in Swagger, it will appear to work and return a customer ID, but unfortunately behind the scenes nothing is stored.

## Task 1

There is a unit test already written in the `Application.Tests` project, but it doesn't pass yet (it doesn't even compile). Make this test pass.

## Task 2

Even though you've got a test working in task 1, you'll find that the `POST /customers` endpoint still isn't storing any data yet. Make a working in memory event repository.

## Task 3

Make a new endpoint `PUT /customers/{customerId}` that will allow us to store an updated event for a customer.

## Task 4

Consider how we would make a `GET /customers/{customerId}` endpoint, which will return the data for a specific customer be reading all the stored events for that customer.