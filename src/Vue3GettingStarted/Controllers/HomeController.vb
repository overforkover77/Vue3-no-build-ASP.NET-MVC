Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Reactivity() As ActionResult
        ViewData("Message") = "Reactivity"
        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."
        Return View()
    End Function

    Function ComputedProperties() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/computed.html"
        Return View()
    End Function

    Function ClassStyleBindings() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/class-and-style.html"
        Return View()
    End Function

    Function ConditionalRendering() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/conditional.html"
        Return View()
    End Function

    Function ListRendering() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/list.html"
        Return View()
    End Function

    Function EventHandling() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/event-handling.html"
        Return View()
    End Function

    Function FormInputBindings() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/forms.html"
        Return View()
    End Function

    Function LifecycleHooks() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/lifecycle.html"
        Return View()
    End Function

    Function Watchers() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/watchers.html"
        Return View()
    End Function

    Function ComponentBasics() As ActionResult
        ViewData("Message") = "https://vuejs.org/guide/essentials/component-basics.html"
        Return View()
    End Function

End Class
