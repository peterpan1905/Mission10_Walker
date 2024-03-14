function Header(props: any) {
  return (
    <header className="row">
      <div className="col-4">
        <h1>{props.title}</h1>
      </div>
      <div className="col">
        <h3>
          A table built using React and ASP.NET with bowler information from the
          Marlins and Sharks
        </h3>
      </div>
    </header>
  );
}

export default Header;
