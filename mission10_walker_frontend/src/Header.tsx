function Header(props: any) {
  return (
    <header className="row">
      <div className="col-4">
        <h1>{props.title}</h1>
      </div>
    </header>
  );
}

export default Header;
