import logo from './MG_logo.png';

function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" style={{ width: '50px' }} />
      </div>
      <div className="col subtitile">
        <h1 className="text-white">{props.title}</h1>
      </div>
    </header>
  );
}

export default Header;
