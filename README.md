### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Prototype pattern
 Create a prototypical instance of kind of object and creates new object using this prototype. \
Generates a photocopy of another object, instead create new form scratch. \
Usefull for complicated constructor phase or resource intensive construction. \
You can use Clone() method instead of another NEW instantiation. \

The shallow copy copy the value of primitive variables, for reference type, shallow copy copies only a reference, not a value.
For copy a value of reference you must use deep copy, copy manualy every reference type in a new reeference type.