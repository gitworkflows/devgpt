import os
from typing import Optional

import typer
import uvicorn
from typing_extensions import Annotated

from .version import VERSION

app = typer.Typer()


@app.command()
def ui(
    host: str = "127.0.0.1",
    port: int = 8081,
    workers: int = 1,
    reload: Annotated[bool, typer.Option("--reload")] = False,
    docs: bool = False,
    appdir: str = None,
    database_uri: Optional[str] = None,
):
    """
    Run the DevGpt Studio UI.

    Args:
        host (str, optional): Host to run the UI on. Defaults to 127.0.0.1 (localhost).
        port (int, optional): Port to run the UI on. Defaults to 8081.
        workers (int, optional): Number of workers to run the UI with. Defaults to 1.
        reload (bool, optional): Whether to reload the UI on code changes. Defaults to False.
        docs (bool, optional): Whether to generate API docs. Defaults to False.
        appdir (str, optional): Path to the DevGpt Studio app directory. Defaults to None.
        database-uri (str, optional): Database URI to connect to. Defaults to None. Examples include sqlite:///devgptstudio.db, postgresql://user:password@localhost/devgptstudio.
    """

    os.environ["DEVGPTSTUDIO_API_DOCS"] = str(docs)
    if appdir:
        os.environ["DEVGPTSTUDIO_APPDIR"] = appdir
    if database_uri:
        os.environ["DEVGPTSTUDIO_DATABASE_URI"] = database_uri

    uvicorn.run(
        "devgptstudio.web.app:app",
        host=host,
        port=port,
        workers=workers,
        reload=reload,
    )


@app.command()
def version():
    """
    Print the version of the DevGpt Studio UI CLI.
    """

    typer.echo(f"DevGpt Studio  CLI version: {VERSION}")


def run():
    app()


if __name__ == "__main__":
    app()
