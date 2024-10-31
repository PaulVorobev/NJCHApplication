import { useEffect, useState } from 'react';
import logo from './logo.png';
import './App.css';

function App() {
    const [accreditations, setAccreditations] = useState();

    useEffect(() => {
        populateWeatherData();
    }, []);

    const myMotto = new Motto("\"Your smile"); 
    const address = <div style={{ marginTop: 2 + 'em'}}>Address: Nicholas James Care Homes Ltd, Head Office, 30 Station Road, Orpington, Kent, BR6 0SA</div>;

    const contents = accreditations === undefined
        ? <p><em>NJCH Awards & Accreditations</em></p>
        : <table className="table table-striped" aria-labelledby="NJCHAwards" style={{ width: 43 + 'em' }} >
            <thead>
                <tr>
                    <th>Nbr.</th>
                    <th>Name</th>
                    <th>Year</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                {accreditations.map(accreditation =>
                    <tr key={accreditation.title}>
                        <td>{accreditation.id}</td>
                        <td>{accreditation.title}</td>
                        <td>{accreditation.ranking}</td>
                        <td>{accreditation.title}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <p><img src={logo} alt="" /></p>
            <h3 id="NJCHAwards">Nicholas James Care Homes Awards & Accreditations</h3>
            <p>
                <a className="App-link" href="https://www.njch.co.uk/" target="_blank" rel="noopener noreferrer">
                    {myMotto.pageMotto()}
                </a>
            </p>
            {contents}            
            {address}            
        </div>
    );

    async function populateWeatherData() {
        const response = await fetch('awards');
        const data = await response.json();
        setAccreditations(data);
    }
}
class Motto {
    constructor(phraseIn) {
        this.yourMotto = phraseIn;
    }

    what = val => " is our " + val + "\""; 

    pageMotto() {
        return this.yourMotto + this.what("Reward");
    }
}

export default App;