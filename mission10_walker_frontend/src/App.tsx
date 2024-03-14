import React from 'react';
import './App.css';
import Header from './Header';
import BowlerTable from './Bowlers/BowlerTable';

function App() {
  return (
    <div className="App">
      <Header title="Bowling League Data" />
      <BowlerTable />
    </div>
  );
}

export default App;
