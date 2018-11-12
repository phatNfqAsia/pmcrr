import React from 'react'
import { Route, Switch } from 'react-router-dom'
import Loadable from 'react-loadable'

const returnNull = () => null;

const SignInPage = Loadable({
    loader: () => import('../page/sign-in-page'),
    loading: returnNull,
})

export default () => (
    <Switch>
        <Route path='/signin' component={SignInPage}></Route>
    </Switch>
)