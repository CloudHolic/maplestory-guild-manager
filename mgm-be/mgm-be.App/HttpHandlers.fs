namespace mgm_be

module HttpHandlers =

    open Microsoft.AspNetCore.Http
    open FSharp.Control.TaskBuilder
    open Giraffe
    open mgm_be.Models

    let handleGetHello =
        fun (next : HttpFunc) (ctx : HttpContext) ->
            task {
                let response = {
                    Text = "Hello world, from Giraffe!"
                }
                return! json response next ctx
            }