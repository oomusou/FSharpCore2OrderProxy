namespace OrderLibrary

module OrderService =
    let getPrice discount price = price * discount * 1.0