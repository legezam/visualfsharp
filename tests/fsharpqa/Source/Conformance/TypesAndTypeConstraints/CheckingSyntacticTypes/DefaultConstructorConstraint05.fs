// #Regression #Conformance #TypeConstraints 
#light
// FSB 2029, default constructor constraint is ignoring the return type of the signature
//<Expects id="FS0700" span="(13,15-13,36)" status="error">'new'.+constraint</Expects>
// DefaultConstructorConstraint05.fs(12,15-12,36): error FS0191: 'new' constraints must take one argument of type 'unit' and return the constructed type.

(*
5.1.5.4	.NET Default  Constructor Constraints
A constraint of the form typar : (new : unit -> 'a) is an explicit .NET default constructor constraint. 
During constraint solving, the constraint type : (new : unit -> 'a) is met if type has a parameterless object constructor.
*)

let h<'a when 'a : (new : 'a -> 'a)> () = new 'a()
