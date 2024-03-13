function BowlerList() {
  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowlers</h4>
      </div>
      <table className="table table-boredered">
        <tr>
          <th>Bowler Name</th>
          <th>Team Name</th>
          <th>Address</th>
          <th>City</th>
          <th>State</th>
          <th>Zip</th>
          <th>Phone Number</th>
        </tr>
      </table>
    </>
  );
}

export default BowlerList;
