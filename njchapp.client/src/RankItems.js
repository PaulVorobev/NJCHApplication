import React, { useState, useEffect } from 'react';    // import two hooks: useState and useEffect - implementing the useState hook so that React can track the state of the items collcection returned from the server

const RankItems = () => {

    const [items, setItems] = useState([]);   // Note empty backets - means (IMO we are just initializing these guys in this line here) that initially our array-variable "items" will be empty - hence we want to our code to call the appropriate Web API component in order to retrieve items collection from the server
    const dataType = 1;

    useEffect(() => {                              // we use JavaScipt "fetch"" method here to make an appropriate HTTP get request to the relevant and we need to pass a value donoting item type -see next line comment
                     fetch('item/${dataType}')               // dataType we pass as an argument here and it is =1 (this constant declared above) and denotes movies becasue we want to pull movies     
                         .then((results) => { 
                             return results.json();
                         })
                         .then(data => {
                             setItems(data);
                         })
    }, [])    // after the first braket we "pass (to the "useEffect" hook) an anonimous function as "the first argument", and empty square brackets in this line as a second argument denoting empty array

    return (
        <main>
            {
                (items != null) ? items.map((item) => <h3>{item.title }</h3>):<div>loading...</div>
            }
        </main>
        )
}