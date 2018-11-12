import React from 'react';
import ReactDOM from 'react-dom'
import Route from './route'
import { Provider } from 'react-redux'
import { ConnectedRouter } from 'react-router-redux'
import { store, history } from './store'

function App() {
    return (
    <Provider store={store}>
      <ConnectedRouter history={history}>
        <Route></Route>
      </ConnectedRouter>
    </Provider>
  )
}

ReactDOM.render(
  App()
, document.getElementById('root'));


