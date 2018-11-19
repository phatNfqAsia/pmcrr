import React from 'react'
import Select from '@atlaskit/select';
import FieldText from '@atlaskit/field-text';
import Button from '@atlaskit/button';
import FieldTextArea from '@atlaskit/field-text-area';
import LogInForm from './log-in-form';


import { SignInPageWrapper } from './styled'

class SignInPage extends React.Component {
    render() {
        return (
            <SignInPageWrapper>
                <LogInForm />    
            </SignInPageWrapper>
        )
    }
}

export default SignInPage;